using System;
using System.IO;
using System.Text;

namespace CyberCAT.Core.ChunkedLz4
{
    public class ChunkedLz4FileHeader
    {
        public int ChunkCount { get; set; }
        public int HeaderSize { get; set; }
        public string Skipped { get; set; }
        public ChunkedLz4FileHeader (Stream input)
        {
            using (var reader = new BinaryReader(input, Encoding.UTF8, true))
            {
                string saveFileHeader = reader.ReadString(4);
                if (saveFileHeader != "VASC")
                {
                    throw new InvalidOperationException();
                }

                // Unknown Data, Checksum?
                Skipped = reader.ReadString(21);

                string chunkedLz4FileHeader = reader.ReadString(4);
                if (chunkedLz4FileHeader != "FZLC")
                {
                    throw new InvalidOperationException();
                }

                ChunkCount = reader.ReadInt32();
                HeaderSize = reader.ReadInt32();
            }
        }

    }
}