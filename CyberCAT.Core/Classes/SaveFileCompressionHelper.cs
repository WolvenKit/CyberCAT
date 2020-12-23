using CyberCAT.Core.ChunkedLz4;
using K4os.Compression.LZ4;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes
{

    public class SaveFileCompressionHelper
    {
        public SaveFileMetaInformation MetaInformation { get; set; }
        public LZ4Level compressionLevel { get; set; }
        ChunkedLz4FileTable Table { get; set; }
        public SaveFileCompressionHelper()
        {
            compressionLevel = LZ4Level.L00_FAST;
            MetaInformation = new SaveFileMetaInformation();
            MetaInformation.FileGuid = Guid.NewGuid();
        }
        private void ReadHeader(Stream input)
        {
            using (var reader = new BinaryReader(input, Encoding.ASCII, true))
            {
                long resumePosition = reader.BaseStream.Position;
                MetaInformation.FirstFileHeaderMarker = reader.ReadString(4);
                reader.BaseStream.Position = resumePosition;
                MetaInformation.FirstHeaderBytes = reader.ReadBytes(4);
                if (MetaInformation.FirstFileHeaderMarker != Constants.Magic.FIRST_FILE_HEADER_MAGIC)
                {
                    throw new InvalidOperationException();
                }

                // Currently Unknown data
                MetaInformation.Skipped = reader.ReadBytes(21);
                resumePosition = reader.BaseStream.Position;
                MetaInformation.SecondFileHeaderMarker = reader.ReadString(4);
                reader.BaseStream.Position = resumePosition;
                MetaInformation.SecondFileHeaderBytes = reader.ReadBytes(4);
                if (MetaInformation.SecondFileHeaderMarker != Constants.Magic.SECOND_FILE_HEADER_MAGIC)
                {
                    throw new InvalidOperationException();
                }
                MetaInformation.ChunkCount = reader.ReadInt32();
                MetaInformation.HeaderSize = reader.ReadInt32();
            }
            
        }
        public byte[] Decompress(Stream input)
        {
            ReadHeader(input);
            Table = ChunkedLz4FileTable.Read(input, MetaInformation.ChunkCount);
            MetaInformation.PartialHeaderSize = MetaInformation.HeaderSize - (input.Position);
            MetaInformation.TrailingFileHeaderContent = new byte[MetaInformation.PartialHeaderSize];
            
            input.Read(MetaInformation.TrailingFileHeaderContent);
            input.Position = MetaInformation.HeaderSize;
            var data = new byte[MetaInformation.HeaderSize + Table.Chunks.Sum(c => c.DecompressedChunkSize)];
            foreach (var chunk in Table.Chunks)
            {
                chunk.Read(input);
            }
            byte[] buffer = new byte[input.Length - input.Position];
            input.Read(buffer, 0, buffer.Length);
            MetaInformation.RestOfContent = buffer;
            int index = 0;
            byte[] result;
            using (var stream = new MemoryStream())
            {
                byte[] header = new byte[3105];
                input.Position = 0;
                input.Read(header, 0, 3105);
                stream.Write(header);
                foreach (var chunk in Table.Chunks)
                {
                    //File.WriteAllBytes($"chunk_{chunk.ChunkGuid}.bin", chunk.DecompressedData);

                    stream.Write(chunk.DecompressedData, 0, chunk.DecompressedData.Length);
                    index++;
                }
                stream.Write(MetaInformation.RestOfContent);
                result = stream.ToArray();
            }
            return result;
        }
        public List<Lz4Chunk> CompressToChunkList(byte[] uncomressedBody)
        {
            var result = new List<Lz4Chunk>();
            List<byte[]> uncompressedChunks = new List<byte[]>();
            using (var stream = new MemoryStream(uncomressedBody))
            {
                using (var reader = new BinaryReader(stream, Encoding.ASCII))
                {
                    long remainingBytes = reader.BaseStream.Length;
                    while (remainingBytes > 262144)
                    {
                        var uncompressedBytes = reader.ReadBytes(262144);
                        uncompressedChunks.Add(uncompressedBytes);
                        remainingBytes = remainingBytes - 262144;
                    }
                    var lastBytes = reader.ReadBytes((int)remainingBytes);
                    uncompressedChunks.Add(lastBytes);
                }
            }
            foreach(var uncompressedChunk in uncompressedChunks)
            {
                var compressedChunk = new Lz4Chunk();
                var target = new byte[LZ4Codec.MaximumOutputSize(uncompressedChunk.Length)];
                int actualSize = LZ4Codec.Encode(uncompressedChunk, target, compressionLevel);
                //need to add 8 because of 4ZLX and size prefix
                compressedChunk.DecompressedChunkSize = uncompressedChunk.Length;
                using (var stream = new MemoryStream())
                {
                    using(var writer = new BinaryWriter(stream, Encoding.ASCII))
                    {
                        writer.Write(Encoding.ASCII.GetBytes(Constants.Magic.LZ4_CHUNK_MAGIC));
                        writer.Write(compressedChunk.DecompressedChunkSize);
                        writer.Write(target, 0, actualSize);
                    }
                    compressedChunk.CompressedData = stream.ToArray();
                    compressedChunk.CompressedChunkSize = compressedChunk.CompressedData.Length;
                }
                result.Add(compressedChunk);
            }
            return result;
        }
        /// <summary>
        /// Recmopresses from single File only supports files where the blocks and Filesize did not change
        /// </summary>
        /// <param name="inputFileName"></param>
        /// <param name="metadataFilePath"></param>
        /// <param name="recompressedFilePath"></param>
        public void CompressFromSingleFile(string inputFileName, string metadataFilePath, out string recompressedFilePath)
        {
            string json = File.ReadAllText(metadataFilePath);
            MetaInformation = JsonConvert.DeserializeObject<SaveFileMetaInformation>(json);
            List<byte[]> dataToCompress = new List<byte[]>();
            
            using (var memoryStream = new MemoryStream())
            {
                using (var writer = new BinaryWriter(memoryStream, Encoding.ASCII))
                {
                    using (var stream = File.OpenRead(inputFileName))
                    {
                        using (var reader = new BinaryReader(stream, Encoding.ASCII, true))
                        {
                            reader.Skip(MetaInformation.HeaderSize);
                            long remainingBytes = reader.BaseStream.Length-MetaInformation.RestOfContent.Length-MetaInformation.HeaderSize;
                            while (remainingBytes >262144)
                            {
                                var uncompressedBytes = reader.ReadBytes(262144);
                                dataToCompress.Add(uncompressedBytes);
                                remainingBytes = remainingBytes - 262144;
                            }
                            var lastBytes = reader.ReadBytes((int)remainingBytes);
                            dataToCompress.Add(lastBytes);
                            reader.Skip((int)(reader.BaseStream.Length - reader.BaseStream.Position));
                        }
                    }
                    writer.Write(MetaInformation.FirstHeaderBytes);
                    writer.Write(MetaInformation.Skipped);
                    writer.Write(MetaInformation.SecondFileHeaderBytes);
                    writer.Write(dataToCompress.Count);
                    writer.Write(MetaInformation.HeaderSize);
                    int offset = MetaInformation.HeaderSize;
                    int index = 0;
                    foreach (var bytesToCompress in dataToCompress)
                    {
                        var target = new byte[LZ4Codec.MaximumOutputSize(bytesToCompress.Length)];
                        int actualSize = LZ4Codec.Encode(bytesToCompress, target, compressionLevel);
                        var compressedData = new byte[actualSize];
                        int fakeSize = actualSize + 8;
                        Array.Copy(target, compressedData, actualSize);
                        Span<byte> outputData = new byte[bytesToCompress.Length];
                        Span<byte> inputData = compressedData;
                        int bytesDecoded = LZ4Codec.Decode(inputData, outputData);
                        writer.Write(fakeSize);//CompressedChunkSize
                        writer.Write(bytesDecoded);//DecompressedChunkSize
                        offset = offset + fakeSize;
                        if (index < dataToCompress.Count - 1)//only write if not last block last blockOffset is stored at -8 of EOF
                        {
                            writer.Write(offset);//EndOfChunkOffset
                        }
                        index++;
                    }
                    writer.Write(MetaInformation.TrailingFileHeaderContent);
                    foreach (var bytesToCompress in dataToCompress)
                    {
                        writer.Write(new byte[] { 52, 90 ,76 ,88 });
                        var target = new byte[LZ4Codec.MaximumOutputSize(bytesToCompress.Length)];
                        int actualSize = LZ4Codec.Encode(bytesToCompress, target, compressionLevel);
                        var compressedData = new byte[actualSize];
                        int fakeSize = actualSize + 8;
                        Array.Copy(target, compressedData, actualSize);
                        Span<byte> outputData = new byte[bytesToCompress.Length];
                        Span<byte> inputData = compressedData;
                        int bytesDecoded = LZ4Codec.Decode(inputData, outputData);
                        writer.Write(bytesDecoded);
                        writer.Write(compressedData);
                    }
                    writer.Write(MetaInformation.RestOfContent,0,MetaInformation.RestOfContent.Length-8);
                    writer.Write(offset);
                    writer.Write(new byte[] { 0x45, 0x4E, 0x4F, 0x44 });

                    recompressedFilePath = $"{Constants.FileStructure.OUTPUT_FOLDER_NAME}\\{MetaInformation.FileGuid}_{Constants.FileStructure.RECOMPRESSED_SUFFIX}.bin";

                    using (var fileStream = File.Create(recompressedFilePath))
                    {
                        memoryStream.Seek(0, SeekOrigin.Begin);
                        memoryStream.CopyTo(fileStream);
                    }
                }  
            }
        }
    }
}
