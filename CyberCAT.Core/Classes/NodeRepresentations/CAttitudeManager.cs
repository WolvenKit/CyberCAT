using System.Collections.Generic;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class CAttitudeManager : NodeRepresentation
    {
        public List<CAttitudeManagerEntry> CAttitudeManagerEntries { get; set; }
        public byte[] Unknown2 { get; set; }

        public CAttitudeManager()
        {
            CAttitudeManagerEntries = new List<CAttitudeManagerEntry>();
        }

        public class CAttitudeManagerEntry
        {
            public ulong Unk_Hash1 { get; set; }
            public uint Unknown2 { get; set; }
        }
    }
}