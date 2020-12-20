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
                    if (i == 14)
                    {
                        int a = 0;
                    }
                    chunks[i] = new Lz4Chunk();
                    chunks[i].CompressedChunkSize = reader.ReadInt32();
                    chunks[i].DecompressedChunkSize = reader.ReadInt32();
                    if (i < chunkCount - 1)
                    {
                        chunks[i].EndOfChunkOffset = reader.ReadInt32();
                    }
                    else
                    {
                        var resumePosition = reader.BaseStream.Position;
                        reader.BaseStream.Seek(-8, SeekOrigin.End);
                        chunks[i].EndOfChunkOffset = reader.ReadInt32();
                        reader.BaseStream.Position = resumePosition;
                    }
                }

                return new ChunkedLz4FileTable
                {
                    Chunks = chunks,
                };
            }
        }
    }
}