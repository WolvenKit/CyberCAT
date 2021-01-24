using System.Collections.Generic;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class ContainerManagerNPCLootBagsVer2 : NodeRepresentation
    {
        public List<Entry> Entries { get; set; }

        public ContainerManagerNPCLootBagsVer2()
        {
            Entries = new List<Entry>();
        }

        public class Entry
        {
            public string Unk_BaseClassName { get; set; }
            public byte[] Unknown2 { get; set; }
            public List<Item> Items { get; set; }
            public ulong EntityId { get; set; }

            public Entry()
            {
                Items = new List<Item>();
            }
        }

        public class Item
        {
            public TweakDbId Unk1_ItemTbdId { get; set; }
            public uint Unk1_Seed { get; set; }
            public ushort Unk2_Counter { get; set; }
            public TweakDbId Unk2_ItemTbdId { get; set; }
            public uint Unk2_Seed { get; set; }
        }
    }
}