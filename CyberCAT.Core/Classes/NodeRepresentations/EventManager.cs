using System.Collections.Generic;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class EventManager : NodeRepresentation
    {
        public List<Entry> Unknown { get; set; }

        public EventManager()
        {
            Unknown = new List<Entry>();
        }

        public class Entry
        {
            public ulong Unknown1 { get; set; }
            public uint Unknown2 { get; set; }
            public ushort Unknown3 { get; set; }
            public ushort Unknown4 { get; set; }
        }
    }
}