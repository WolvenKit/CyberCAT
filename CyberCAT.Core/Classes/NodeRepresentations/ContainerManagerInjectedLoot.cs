using System.Collections.Generic;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class ContainerManagerInjectedLoot : NodeRepresentation
    {
        public List<Entry> Entries { get; set; }

        public ContainerManagerInjectedLoot()
        {
            Entries = new List<Entry>();
        }

        public class Entry
        {
            public ulong EntityId { get; set; }
            public List<SubEntry> Entries { get; set; }
        }

        public class SubEntry
        {
            public TweakDbId ItemTbdId { get; set; }
            public byte Unknown2 { get; set; }
            public uint Unknown3 { get; set; }
            public byte Unknown4 { get; set; }
        }
    }
}