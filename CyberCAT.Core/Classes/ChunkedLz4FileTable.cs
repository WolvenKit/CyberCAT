using System.IO;
using System.Text;

namespace CyberCAT.Core.ChunkedLz4
{
    public class ChunkedLz4FileTable
    {
        public Lz4Chunk[] Chunks { get; set; }

        public static ChunkedLz4FileTable Read(Stream input, int chunkCount)
        {
            using (var reader = new BinaryReader(input, Encoding.UTF8, true))
            {
                Lz4Chunk[] chunks = new Lz4Chunk[chunkCount];
                for (int i = 0; i < chunkCount; i++)
                {
                    chunks[i] = new Lz4Chunk
                    {
                        CompressedChunkSize = reader.ReadInt32(),
                        DecompressedChunkSize = reader.ReadInt32(),
                        EndOfChunkOffset = reader.ReadInt32()
                    };
                }

                return new ChunkedLz4FileTable
                {
                    Chunks = chunks,
                };
            }
        }
    }
}