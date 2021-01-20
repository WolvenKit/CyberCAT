using System.Collections.Generic;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class DSDynamicConnections : NodeRepresentation
    {
        public List<Entry> Entries { get; set; }

        public DSDynamicConnections()
        {
            Entries = new List<Entry>();
        }

        public class Entry
        {
            public ulong Unknown1 { get; set; }
            public string Unknown2 { get; set; }
            public List<ulong> Unknown3 { get; set; }
            public List<ulong> Unknown4 { get; set; }
            public byte[] Unknown5 { get; set; }
            public string Unknown6 { get; set; }

            public Entry()
            {
                Unknown3 = new List<ulong>();
                Unknown4 = new List<ulong>();
            }
        }
    }
}