using System;
using System.Diagnostics;
using System.IO;
using K4os.Compression.LZ4;

namespace CyberCAT.Core.ChunkedLz4
{
    public class Lz4Chunk
    {
        public int CompressedChunkSize { get; set; }

        public int DecompressedChunkSize { get; set; }

        public int EndOfChunkOffset { get; set; }

        public byte[] Skipped { get; set; }

        public byte[] DecompressedData { get; set; }

        public byte[] CompressedData { get; set; }
        public Guid ChunkGuid { get; set; }

        public Lz4Chunk()
        {
            ChunkGuid = Guid.NewGuid();
        }
        public void Read(Stream inputStream)
        {
            Span<byte> inputData = new byte[CompressedChunkSize-8];
            Span<byte> outputData = new byte[DecompressedChunkSize];
            Skipped = new byte[8];
            inputStream.Read(Skipped);
            //inputStream.Seek(8, SeekOrigin.Current);
            inputStream.Read(inputData);
            CompressedData = inputData.ToArray();
            int bytesDecoded = LZ4Codec.Decode(inputData, outputData);

            Debug.Assert(bytesDecoded == DecompressedChunkSize);

            Debug.Assert(inputStream.Position == EndOfChunkOffset || EndOfChunkOffset == 0);

            DecompressedData = outputData.ToArray();
        }
    }
}
