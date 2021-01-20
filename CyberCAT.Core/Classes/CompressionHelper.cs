using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using K4os.Compression.LZ4;

namespace CyberCAT.Core.Classes
{
    public class CompressionHelper
    {
        private static void WriteChunkTable(BinaryWriter writer, List<DataChunkInfo> chunkInfos)
        {
            var pos = writer.BaseStream.Position;
            writer.BaseStream.SeekMagicBytes(Constants.Magic.SECOND_FILE_HEADER_MAGIC);
            // SeekMagicBytes jumps to the position before the magic bytes
            writer.BaseStream.Position += 4;

            writer.Write(chunkInfos.Count);
            foreach (var chunk in chunkInfos)
            {
                writer.Write(chunk.Offset);
                writer.Write(chunk.CompressedSize);
                writer.Write(chunk.DecompressedSize);
            }

            writer.BaseStream.Position = pos;
        }

        public static void WriteUncompressed(BinaryWriter writer, byte[] data)
        {
            var chunkCount = data.Length / Constants.Numbers.DEFAULT_CHUNK_SIZE;
            var chunkBytesLeft = data.Length % Constants.Numbers.DEFAULT_CHUNK_SIZE;

            var chunks = new List<DataChunkInfo>();
            var index = 0;
            for (; index < chunkCount; index++)
            {
                chunks.Add(new DataChunkInfo
                {
                    Offset = index * Constants.Numbers.DEFAULT_CHUNK_SIZE + Constants.Numbers.DEFAULT_HEADER_SIZE,
                    CompressedSize = Constants.Numbers.DEFAULT_CHUNK_SIZE,
                    DecompressedSize = Constants.Numbers.DEFAULT_CHUNK_SIZE
                });
            }

            chunks.Add(new DataChunkInfo
            {
                Offset = index * Constants.Numbers.DEFAULT_CHUNK_SIZE + Constants.Numbers.DEFAULT_HEADER_SIZE,
                CompressedSize = chunkBytesLeft,
                DecompressedSize = chunkBytesLeft
            });

            writer.Write(data);
            WriteChunkTable(writer, chunks);
        }

        public static void WriteCompressed(BinaryWriter writer, byte[] data)
        {
            var chunkCount = data.Length / Constants.Numbers.DEFAULT_CHUNK_SIZE;
            var chunkBytesLeft = data.Length % Constants.Numbers.DEFAULT_CHUNK_SIZE;
            byte[] inBuffer;

            var chunks = new List<DataChunkInfo>();
            var index = 0;
            for (; index < chunkCount; index++)
            {
                inBuffer = new byte[Constants.Numbers.DEFAULT_CHUNK_SIZE];
                Array.Copy(data, index * Constants.Numbers.DEFAULT_CHUNK_SIZE, inBuffer, 0, inBuffer.Length);
                chunks.Add(WriteChunk(writer, inBuffer));
            }

            inBuffer = new byte[chunkBytesLeft];
            Array.Copy(data, index * Constants.Numbers.DEFAULT_CHUNK_SIZE, inBuffer, 0, inBuffer.Length);
            chunks.Add(WriteChunk(writer, inBuffer));

            WriteChunkTable(writer, chunks);
        }

        private static DataChunkInfo WriteChunk(BinaryWriter writer, byte[] inBuffer)
        {
            var offset = (int)writer.BaseStream.Position;

            var outBuffer = new byte[LZ4Codec.MaximumOutputSize(inBuffer.Length)];
            var compressedSize = LZ4Codec.Encode(inBuffer, 0, inBuffer.Length, outBuffer, 0, outBuffer.Length);

            writer.Write(Encoding.ASCII.GetBytes(Constants.Magic.LZ4_CHUNK_MAGIC));
            writer.Write(inBuffer.Length);
            writer.Write(outBuffer, 0, compressedSize);

            return new DataChunkInfo
            {
                Offset = offset,
                CompressedSize = compressedSize + 8,
                DecompressedSize = inBuffer.Length
            };
        }

        public static byte[] Recompress(Stream stream)
        {
            var resultBuffer = new byte[0];

            stream.Position = stream.Length - 8;
            var infoPosBuffer = new byte[4];
            stream.Read(infoPosBuffer, 0, infoPosBuffer.Length);
            var infoPos = BitConverter.ToInt32(infoPosBuffer, 0);
            stream.Position = 0;

            var headerBuffer = new byte[Constants.Numbers.DEFAULT_HEADER_SIZE];
            stream.Read(headerBuffer, 0, headerBuffer.Length);
            var dataBuffer = new byte[infoPos - stream.Position];
            stream.Read(dataBuffer, 0, dataBuffer.Length);
            var footerBuffer = new byte[stream.Length - infoPos];
            stream.Read(footerBuffer, 0, footerBuffer.Length);

            using (var ms = new MemoryStream())
            {
                using (var writer = new BinaryWriter(ms))
                {
                    writer.Write(headerBuffer);
                    WriteCompressed(writer, dataBuffer);

                    var pos = (int) writer.BaseStream.Position;
                    writer.Write(footerBuffer);
                    writer.BaseStream.Seek(-8, SeekOrigin.End);
                    writer.Write(pos);
                }

                resultBuffer = ms.ToArray();
            }

            return resultBuffer;
        }

        public static byte[] Decompress(Stream stream)
        {
            byte[] buffer = new byte[0];

            using (var reader = new BinaryReader(stream))
            {
                var decompressedStream = Decompress(reader);

                using (var writer = new BinaryWriter(decompressedStream, Encoding.ASCII, true))
                {
                    writer.Seek(0, SeekOrigin.End);
                    var pos = writer.BaseStream.Position;
                    writer.Write(reader.ReadBytes((int) (reader.BaseStream.Length - reader.BaseStream.Position)));
                    writer.Seek(-8, SeekOrigin.End);
                    writer.Write((int) pos);
                }

                using (var ms = new MemoryStream())
                {
                    decompressedStream.Position = 0;
                    decompressedStream.CopyTo(ms);
                    buffer = ms.ToArray();
                }
            }

            return buffer;
        }

        public static Stream Decompress(BinaryReader reader)
        {
            var result = new MemoryStream();

            var infoPos = reader.BaseStream.SeekMagicBytes(Constants.Magic.SECOND_FILE_HEADER_MAGIC) + 4;
            reader.BaseStream.Position = 0;
            result.Write(reader.ReadBytes((int) infoPos));
            result.Write(new byte[Constants.Numbers.DEFAULT_HEADER_SIZE - result.Position]);

            var compressedChunks = new List<DataChunkInfo>();
            var counter = reader.ReadInt32();
            for (int i = 0; i < counter; i++)
            {
                compressedChunks.Add(new DataChunkInfo
                {
                    Offset = reader.ReadInt32(),
                    CompressedSize = reader.ReadInt32(),
                    DecompressedSize = reader.ReadInt32()
                });
            }

            reader.BaseStream.Position = Constants.Numbers.DEFAULT_HEADER_SIZE;

            var magicInt = BitConverter.ToUInt32(Encoding.ASCII.GetBytes(Constants.Magic.LZ4_CHUNK_MAGIC), 0);
            using (var ms = new MemoryStream())
            {
                using (var writer = new BinaryWriter(ms))
                {
                    foreach (var chunk in compressedChunks)
                    {
                        Debug.Assert(reader.BaseStream.Position == chunk.Offset);

                        byte[] outBuffer;

                        if (reader.ReadUInt32() == magicInt)
                        {
                            var decompressedSize = reader.ReadUInt32();
                            var inBuffer = reader.ReadBytes(chunk.CompressedSize - 8);
                            outBuffer = new byte[chunk.DecompressedSize];
                            LZ4Codec.Decode(inBuffer, 0, inBuffer.Length, outBuffer, 0, outBuffer.Length);
                        }
                        else
                        {
                            reader.BaseStream.Position -= 4;
                            outBuffer = reader.ReadBytes(chunk.CompressedSize);
                        }

                        writer.Write(outBuffer);
                    }
                }

                using (var writer = new BinaryWriter(result, Encoding.ASCII, true))
                {
                    WriteUncompressed(writer, ms.ToArray());
                }
            }

            result.Position = 0;

            return result;
        }

        private class DataChunkInfo
        {
            public int Offset { get; set; }
            public int CompressedSize { get; set; }
            public int DecompressedSize { get; set; }
        }
    }
}