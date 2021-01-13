using System.Collections.Generic;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class CCoverManager : NodeRepresentation
    {
        public List<CCoverManagerEntry> Entries { get; set; }

        public CCoverManager()
        {
            Entries = new List<CCoverManagerEntry>();
        }

        public class CCoverManagerEntry
        {
            public ulong Unk_Hash1 { get; set; }
            public ulong Unk_EntityHash { get; set; }

            // probably bool, if this is true, the hashes are also used somewhere els in the save
            public byte Unknown3 { get; set; }
        }
    }
}