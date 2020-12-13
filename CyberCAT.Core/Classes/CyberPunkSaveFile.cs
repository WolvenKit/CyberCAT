using CyberCAT.Core.ChunkedLz4;
using K4os.Compression.LZ4;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes
{

    public class CyberPunkSaveFile
    {
        int ChunkCount { get; set; }
        int HeaderSize { get; set; }
        long PartialHeaderSize { get; set; }
        string FirstFileHeaderMarker { get; set; }
        byte[] FirstHeaderBytes { get; set; }
        string SecondFileHeaderMarker { get; set; }
        byte[] SecondFileHeaderBytes { get; set; }
        byte[] Skipped { get; set; }
        byte[] TrailingFileHeaderContent { get; set; }
        byte[] RestOfContent { get; set; }
        ChunkedLz4FileTable Table { get; set; }

        public void ReadHeader(Stream input)
        {
            using (var reader = new BinaryReader(input, Encoding.UTF8, true))
            {
                long resumePosition = reader.BaseStream.Position;
                FirstFileHeaderMarker = reader.ReadString(4);
                reader.BaseStream.Position = resumePosition;
                FirstHeaderBytes = reader.ReadBytes(4);
                if (FirstFileHeaderMarker != Constants.SaveFile.FIRST_FILE_HEADER_STRING)
                {
                    throw new InvalidOperationException();
                }

                // Currently Unknown data
                Skipped = reader.ReadBytes(21);
                resumePosition = reader.BaseStream.Position;
                SecondFileHeaderMarker = reader.ReadString(4);
                reader.BaseStream.Position = resumePosition;
                SecondFileHeaderBytes = reader.ReadBytes(4);
                if (SecondFileHeaderMarker != Constants.SaveFile.SECOND_FILE_HEADER_STRING)
                {
                    throw new InvalidOperationException();
                }
                ChunkCount = reader.ReadInt32();
                HeaderSize = reader.ReadInt32();
            }
            
        }
        public void Decompress(Stream input)
        {
            Table = ChunkedLz4FileTable.Read(input, ChunkCount);
            PartialHeaderSize = HeaderSize-(input.Position);
            TrailingFileHeaderContent = new byte[PartialHeaderSize];
            input.Read(TrailingFileHeaderContent);
            input.Position = HeaderSize;
            var data = new byte[HeaderSize + Table.Chunks.Sum(c => c.DecompressedChunkSize)];
            foreach (var chunk in Table.Chunks)
            {
                chunk.Read(input);
            }
            byte[] buffer = new byte[input.Length - input.Position];
            input.Read(buffer, 0, buffer.Length);
            RestOfContent = buffer;
            int index = 0;
            foreach (var chunk in Table.Chunks)
            {
                File.WriteAllBytes($"chunk_{index}.bin", chunk.DecompressedData);
                index++;
            }
        }
        public void Compress(string outputFileName)
        {
            using (var memoryStream = new MemoryStream())
            {
                using (var writer = new BinaryWriter(memoryStream, Encoding.UTF8))
                {
                    writer.Write(FirstHeaderBytes);
                    writer.Write(Skipped);
                    writer.Write(SecondFileHeaderBytes);
                    writer.Write(ChunkCount);
                    writer.Write(HeaderSize);
                    int offset = HeaderSize;
                    int index = 0;
                    foreach (var chunk in Table.Chunks)
                    {
                        var target = new byte[LZ4Codec.MaximumOutputSize(chunk.DecompressedData.Length)];
                        int actualSize = LZ4Codec.Encode(chunk.DecompressedData, target, LZ4Level.L00_FAST);
                        var compressedData = new byte[actualSize];
                        int fakeSize = actualSize + 8;
                        Array.Copy(target, compressedData, actualSize);
                        Span<byte> outputData = new byte[chunk.DecompressedChunkSize];
                        Span<byte> inputData = compressedData;
                        int bytesDecoded = LZ4Codec.Decode(inputData, outputData);
                        if (bytesDecoded != chunk.DecompressedChunkSize)
                        {
                            throw new Exception("Unexpected bytesDecoded");//TODO Remove this when modifications are possible
                        }
                        File.WriteAllBytes($"test_Chunk{index}.bin", compressedData);
                        writer.Write(fakeSize);//CompressedChunkSize
                        writer.Write(bytesDecoded);//DecompressedChunkSize
                        offset = offset + fakeSize;
                        if (index < Table.Chunks.Length-1)
                        {
                            writer.Write(offset);//EndOfChunkOffset
                        }
                        else
                        {
                            writer.Write(0);
                        }
                        index++;
                    }
                    writer.Write(TrailingFileHeaderContent);
                    foreach (var chunk in Table.Chunks)
                    {
                        writer.Write(chunk.Skipped, 0, 4);
                        var target = new byte[LZ4Codec.MaximumOutputSize(chunk.DecompressedData.Length)];
                        int actualSize = LZ4Codec.Encode(chunk.DecompressedData, target, LZ4Level.L00_FAST);
                        var compressedData = new byte[actualSize];
                        int fakeSize = actualSize + 8;
                        Array.Copy(target, compressedData, actualSize);
                        Span<byte> outputData = new byte[chunk.DecompressedChunkSize];
                        Span<byte> inputData = compressedData;
                        int bytesDecoded = LZ4Codec.Decode(inputData, outputData);
                        if (bytesDecoded != chunk.DecompressedChunkSize)
                        {
                            throw new Exception("Unexpected bytesDecoded");//TODO Remove this when modifications are possible
                        }
                        writer.Write(bytesDecoded);
                        writer.Write(compressedData);
                    }
                    writer.Write(RestOfContent);
                    using (var fileStream = File.Create(outputFileName))
                    {
                        memoryStream.Seek(0, SeekOrigin.Begin);
                        memoryStream.CopyTo(fileStream);
                    }
                }
            }
        }
    }
}
