using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class ItemData
    {
        public class NextItemEntry
        {
            public ulong ItemTdbId { get; set; }
            public uint ItemID { get; set; }
            public byte[] UnknownBytes { get; set; }
            public override string ToString()
            {
                return NameResolver.GetName(ItemTdbId);
            }
        }

        public class ItemFlags
        {
            public byte Raw { get; set; }
            public bool IsQuestItem
            {
                get => (Raw & 0x01) == 0x01;
                set
                {
                    if (value)
                    {
                        Raw |= 0x01;
                    } else {
                        Raw &= byte.MaxValue ^ (0x01);
                    }
                } 
            }
            public bool Unknown2
            {
                get => (Raw & 0x02) == 0x02;
                set
                {
                    if (value)
                    {
                        Raw |= 0x02;
                    }
                    else
                    {
                        Raw &= byte.MaxValue ^ (0x02);
                    }
                }
            }

            public ItemFlags(byte raw)
            {
                Raw = raw;
            }

            public override string ToString()
            {
                return $"[......{(Unknown2 ? '?' : '.')}{(IsQuestItem ? 'Q' : '.')}]";
            }
        }

        public class ModEntry
        {
            public ulong ItemTdbId { get; set; }
            public uint ItemID { get; set; }
            public byte[] UnknownBytes1 { get; set; }
            public string UnknownString { get; set; }
            public byte[] UnknownBytes2 { get; set; }

            public override string ToString()
            {
                return NameResolver.GetName(ItemTdbId);
            }
        }

        public ulong ItemTdbId { get; set; }
        public uint ItemID { get; set; }
        public byte[] UnknownBytes1 { get; set; }
        public ItemFlags Flags { get; set; }
        public uint CreationTime { get; set; }
        public uint ItemQuantity { get; set; }
        public byte[] UnknownBytes3 { get; set; }
        public List<ModEntry> ModEntries { get; set; }
        public byte[] ItemDataBytes { get; set; }

        public ItemData()
        {
            ModEntries = new List<ModEntry>();
        }

        public override string ToString()
        {
            return NameResolver.GetName(ItemTdbId);
        }
    }
}
