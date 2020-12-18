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

    public class CyberPunkSaveFile
    {
        public SaveFileMetaInformation MetaInformation { get; set; }
        public LZ4Level compressionLevel { get; set; }
        ChunkedLz4FileTable Table { get; set; }
        public CyberPunkSaveFile()
        {
            compressionLevel = LZ4Level.L00_FAST;
            MetaInformation = new SaveFileMetaInformation();
            MetaInformation.FileGuid = Guid.NewGuid();
        }
        public void ReadHeader(Stream input)
        {
            using (var reader = new BinaryReader(input, Encoding.UTF8, true))
            {
                long resumePosition = reader.BaseStream.Position;
                MetaInformation.FirstFileHeaderMarker = reader.ReadString(4);
                reader.BaseStream.Position = resumePosition;
                MetaInformation.FirstHeaderBytes = reader.ReadBytes(4);
                if (MetaInformation.FirstFileHeaderMarker != Constants.SaveFile.FIRST_FILE_HEADER_STRING)
                {
                    throw new InvalidOperationException();
                }

                // Currently Unknown data
                MetaInformation.Skipped = reader.ReadBytes(21);
                resumePosition = reader.BaseStream.Position;
                MetaInformation.SecondFileHeaderMarker = reader.ReadString(4);
                reader.BaseStream.Position = resumePosition;
                MetaInformation.SecondFileHeaderBytes = reader.ReadBytes(4);
                if (MetaInformation.SecondFileHeaderMarker != Constants.SaveFile.SECOND_FILE_HEADER_STRING)
                {
                    throw new InvalidOperationException();
                }
                MetaInformation.ChunkCount = reader.ReadInt32();
                MetaInformation.HeaderSize = reader.ReadInt32();
            }
            
        }
        public void Decompress(Stream input)
        {
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
            using (var stream = new FileStream($"{Constants.FileStructure.OUTPUT_FOLDER_NAME}\\{MetaInformation.FileGuid}_{Constants.FileStructure.UNCOMPRESSED_SUFFIX}.bin", FileMode.Create))
            {
                foreach (var chunk in Table.Chunks)
                {
                    //File.WriteAllBytes($"chunk_{chunk.ChunkGuid}.bin", chunk.DecompressedData);

                    stream.Write(chunk.DecompressedData, 0, chunk.DecompressedData.Length);


                    index++;
                }
            }
            string json = JsonConvert.SerializeObject(MetaInformation, Formatting.Indented);
            File.WriteAllText($"{Constants.FileStructure.OUTPUT_FOLDER_NAME}\\{MetaInformation.FileGuid}_{Constants.FileStructure.METAINFORMATION_SUFFIX}.json",json);

        }
        public void CompressFromSingleFile(string inputFileName,string metadataFilePath)
        {
            string json = File.ReadAllText(metadataFilePath);
            MetaInformation = JsonConvert.DeserializeObject<SaveFileMetaInformation>(json);
            List<byte[]> dataToCompress = new List<byte[]>();
            
            using (var memoryStream = new MemoryStream())
            {
                using (var writer = new BinaryWriter(memoryStream, Encoding.UTF8))
                {
                    using (var stream = File.OpenRead(inputFileName))
                    {
                        using (var reader = new BinaryReader(stream, Encoding.UTF8, true))
                        {
                            long remainingBytes = reader.BaseStream.Length;
                            while (remainingBytes >262144)
                            {
                                var uncompressedBytes = reader.ReadBytes(262144);
                                dataToCompress.Add(uncompressedBytes);
                                remainingBytes = remainingBytes - 262144;
                            }
                            var lastBytes = reader.ReadBytes((int)remainingBytes);
                            dataToCompress.Add(lastBytes);

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
                        if (index < dataToCompress.Count - 1)
                        {
                            writer.Write(offset);//EndOfChunkOffset
                        }
                        else
                        {
                            writer.Write(0);
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
                        if (bytesDecoded != bytesToCompress.Length)
                        {
                            int a = 1;
                        }
                        writer.Write(bytesDecoded);
                        writer.Write(compressedData);
                    }
                    writer.Write(MetaInformation.RestOfContent,0,MetaInformation.RestOfContent.Length-8);
                    writer.Write(offset);
                    writer.Write(new byte[] { 0x45, 0x4E, 0x4F, 0x44 });
                    using (var fileStream = File.Create($"{Constants.FileStructure.OUTPUT_FOLDER_NAME}\\{MetaInformation.FileGuid}_{Constants.FileStructure.RECOMPRESSED_SUFFIX}.bin"))
                    {
                        memoryStream.Seek(0, SeekOrigin.Begin);
                        memoryStream.CopyTo(fileStream);
                    }
                }  
            }
        }
    }
}
