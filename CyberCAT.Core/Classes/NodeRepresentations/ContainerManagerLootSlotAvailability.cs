using System.Collections.Generic;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class ContainerManagerLootSlotAvailability : NodeRepresentation
    {
        public List<Entry> Entries { get; set; }

        public ContainerManagerLootSlotAvailability()
        {
            Entries = new List<Entry>();
        }

        public class Entry
        {
            public ulong CNameHash { get; set; }
            public byte Unknown1 { get; set; }
        }
    }
}