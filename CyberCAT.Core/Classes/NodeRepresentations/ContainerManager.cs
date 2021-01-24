using System.Collections.Generic;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class ContainerManager : NodeRepresentation
    {
        public List<Entry> Entries { get; set; }

        public ContainerManager()
        {
            Entries = new List<Entry>();
        }

        public class Entry
        {
            public ulong CNameHash { get; set; }
            public ushort Unknown1 { get; set; }
        }
    }
}