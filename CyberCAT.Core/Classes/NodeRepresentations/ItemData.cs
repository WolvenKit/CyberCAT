using Newtonsoft.Json;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    [JsonObject]
    public class ItemData
    {
        public class NextItemEntry
        {
            public TweakDbId ItemTdbId { get; set; }
            public string ItemName => NameResolver.GetName(ItemTdbId);
            public string ItemGameName => NameResolver.GetGameName(ItemTdbId);
            public string ItemGameDescription => NameResolver.GetGameDescription(ItemTdbId);
            public uint ItemID { get; set; }
            public byte[] UnknownBytes { get; set; }
            public override string ToString()
            {
                return $"{ItemName} ({ItemGameName})";
            }
        }
        [JsonObject]
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
        [JsonObject]
        public class ItemInnerData
        {

        }
        [JsonObject]
        public class SimpleItemData : ItemInnerData
        {
            public uint Quantity { get; set; }

            public override string ToString()
            {
                return $"{Quantity}x";
            }
        }
        [JsonObject]
        public class ModableItemData : ItemInnerData
        {
            public TweakDbId TdbId1 { get; set; }
            public string TdbId1Name => NameResolver.GetName(TdbId1);
            public uint Unknown2 { get; set; }
            public uint Unknown3 { get; set; }
            public ItemModData RootNode { get; set; }

            public override string ToString()
            {
                return $"{TdbId1Name}";
            }
        }

        [JsonObject]
        public class ModableItemWithQuantityData : ModableItemData
        {
            public uint Quantity { get; set; }
        }
        [JsonObject]
        public class ItemModData
        {
            public TweakDbId ItemTdbId { get; set; }
            public string ItemName => NameResolver.GetName(ItemTdbId);
            public string ItemGameName => NameResolver.GetGameName(ItemTdbId);
            public string ItemGameDescription => NameResolver.GetGameDescription(ItemTdbId);
            public HeaderThing Header { get; set; }
            public string UnknownString { get; set; }
            public ulong AttachmentSlotTdbId { get; set; }
            public string AttachmentSlotName => NameResolver.GetName(AttachmentSlotTdbId);
            public int ChildrenCount => Children?.Length ?? 0;
            public ItemModData[] Children { get; set; }
            public uint Unknown2 { get; set; }
            public TweakDbId TdbId2 { get; set; }
            public string TdbId2Name => NameResolver.GetName(TdbId2);
            public uint Unknown3 { get; set; }
            public uint Unknown4 { get; set; }
            public override string ToString()
            {
                return string.IsNullOrWhiteSpace(ItemGameName) ? ItemName : $"{ItemName} ({ItemGameName})";
            }
        }
        [JsonObject]
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
                return $"Type: {Kind} | {ItemId:X8}";
            }
        }

        public TweakDbId ItemTdbId { get; set; }
        public string ItemName => NameResolver.GetName(ItemTdbId);
        public string ItemGameName => NameResolver.GetGameName(ItemTdbId);
        public string ItemGameDescription => NameResolver.GetGameDescription(ItemTdbId);

        public HeaderThing Header { get; set; }
        public ItemFlags Flags { get; set; }
        public uint CreationTime { get; set; }

        public ItemInnerData Data { get; set; }

        //public byte[] TrailingBytes { get; set; }

        public override string ToString()
        {
            return string.IsNullOrWhiteSpace(ItemGameName) ? ItemName : $"{ItemName} ({ItemGameName})";
        }
    }
}
