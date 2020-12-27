namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class ItemData
    {
        public class NextItemEntry
        {
            public ulong ItemTdbId { get; set; }
            public string ItemName => NameResolver.GetName(ItemTdbId);
            public uint ItemID { get; set; }
            public byte[] UnknownBytes { get; set; }
            public override string ToString()
            {
                return ItemName;
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

        public class KindData
        {

        }

        public class Kind1Data : KindData
        {
            public ItemFlags Flags { get; set; }
            public uint CreationTime { get; set; }
            public uint Unknown2 { get; set; }
        }

        public class Kind2Data : KindData
        {
            public ItemFlags Flags { get; set; }
            public uint CreationTime { get; set; }
            public ulong TdbId1 { get; set; }
            public string TdbId1Name => NameResolver.GetName(TdbId1);
            public uint Unknown2 { get; set; }
            public uint Unknown3 { get; set; }
            public Kind2DataNode RootNode { get; set; }
        }

        public class Kind2DataNode
        {
            public ulong ItemTdbId { get; set; }
            public string ItemName => NameResolver.GetName(ItemTdbId);
            public HeaderThing Header { get; set; }
            public string UnknownString { get; set; }
            public ulong TdbId1 { get; set; }
            public string TdbId1Name => NameResolver.GetName(TdbId1);
            public int ChildrenCount => Children.Length;
            public Kind2DataNode[] Children { get; set; }
            public uint Unknown2 { get; set; }
            public ulong TdbId2 { get; set; }
            public string TdbId2Name => NameResolver.GetName(TdbId2);
            public uint Unknown3 { get; set; }
            public uint Unknown4 { get; set; }
            public override string ToString()
            {
                return ItemName;
            }
        }

        public class HeaderThing
        {
            public uint ItemId { get; set; }
            public byte UnknownBytes1 { get; set; }
            public ushort UnknownBytes2 { get; set; }

            public byte Kind
            {
                get
                {
                    if (UnknownBytes1 == 1)
                        return 2;
                    if (UnknownBytes1 == 2)
                        return 1;
                    if (UnknownBytes1 == 3)
                        return 0;
                    return (byte)(ItemId != 2 ? 2 : 1);
                }
            }

            public override string ToString()
            {
                return $"Kind: {Kind}";
            }
        }

        public ulong ItemTdbId { get; set; }
        public string ItemName => NameResolver.GetName(ItemTdbId);

        public HeaderThing Header { get; set; }

        public KindData Data { get; set; }

        public byte[] TrailingBytes { get; set; }

        public override string ToString()
        {
            return ItemName;
        }
    }
}
