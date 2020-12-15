using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes
{
    /// <summary>
    /// Used to store some Information about the uncompressed File
    /// Should not be needed once the Format is fully understood.
    /// </summary>
    public class SaveFileMetaInformation
    {
        public int ChunkCount { get; set; }
        public int HeaderSize { get; set; }
        public long PartialHeaderSize { get; set; }
        public string FirstFileHeaderMarker { get; set; }
        public byte[] FirstHeaderBytes { get; set; }
        public string SecondFileHeaderMarker { get; set; }
        public byte[] SecondFileHeaderBytes { get; set; }
        public byte[] Skipped { get; set; }
        public byte[] TrailingFileHeaderContent { get; set; }
        public byte[] RestOfContent { get; set; }
        public Guid FileGuid { get; set; }

        public SaveFileMetaInformation()
        {

        }
    }
}
