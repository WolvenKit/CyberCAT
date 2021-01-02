using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.Parsers;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class ItemDataParser : INodeParser
    {
        public string ParsableNodeName { get; }

        public string DisplayName { get; }

        public Guid Guid { get; }

        public ItemDataParser()
        {
            ParsableNodeName = Constants.NodeNames.ITEM_DATA;
            DisplayName = "ItemData Parser";
            Guid = Guid.Parse("{B05D52F2-44B5-4122-AB5D-7B84E99C784C}");
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new ItemData();

            reader.Skip(4); // Skip Id

            result.ItemTdbId = reader.ReadUInt64();
            result.Header = ReadHeaderThing(reader);
            result.Flags = new ItemData.ItemFlags(reader.ReadByte());
            result.CreationTime = reader.ReadUInt32();

            switch (result.Header.Kind)
            {
                case 0:
                    result.Data = ReadModableItemWithQuantityData(reader);
                    break;
                case 1:
                    result.Data = ReadSimpleItemData(reader);
                    break;
                case 2:
                    result.Data = ReadModableItemData(reader);
                    break;
            }

            // There should be no bytes left after an item.
            var toRead = node.Size - (reader.BaseStream.Position - node.Offset);
            Debug.Assert(toRead == 0);
            //result.TrailingBytes = reader.ReadBytes((int)toRead);

            return result;
        }

        public static ItemData.HeaderThing ReadHeaderThing(BinaryReader reader)
        {
            var result = new ItemData.HeaderThing();

            result.ItemId = reader.ReadUInt32();
            result.UnknownBytes1 = reader.ReadByte();
            result.UnknownBytes2 = reader.ReadUInt16();
            return result;
        }

        public static ItemData.SimpleItemData ReadSimpleItemData(BinaryReader reader)
        {
            var result = new ItemData.SimpleItemData();

            result.Quantity = reader.ReadUInt32();

            return result;
        }

        public static ItemData.ModableItemWithQuantityData ReadModableItemWithQuantityData(BinaryReader reader)
        {
            var result = new ItemData.ModableItemWithQuantityData();

            result.Quantity = reader.ReadUInt32();
            var modItem = ReadModableItemData(reader);
            result.TdbId1 = modItem.TdbId1;
            result.Unknown2 = modItem.Unknown2;
            result.Unknown3 = modItem.Unknown3;
            result.RootNode = modItem.RootNode;

            return result;
        }

        public static ItemData.ModableItemData ReadModableItemData(BinaryReader reader)
        {
            var result = new ItemData.ModableItemData();

            result.TdbId1 = reader.ReadUInt64();
            result.Unknown2 = reader.ReadUInt32();
            result.Unknown3 = reader.ReadUInt32();
            result.RootNode = ReadKind2DataNode(reader);

            return result;
        }

        public static ItemData.ItemModData ReadKind2DataNode(BinaryReader reader)
        {
            var result = new ItemData.ItemModData();

            result.ItemTdbId = reader.ReadUInt64();
            result.Header = ReadHeaderThing(reader);
            result.UnknownString = ParserUtils.ReadString(reader);
            result.AttachmentSlotTdbId = reader.ReadUInt64();
            var count = ParserUtils.ReadPackedLong(reader);
            result.Children = new ItemData.ItemModData[count];
            for(var i = 0; i < count; ++i)
            {
                result.Children[i] = ReadKind2DataNode(reader);
            }

            result.Unknown2 = reader.ReadUInt32();
            result.TdbId2 = reader.ReadUInt64();
            result.Unknown3 = reader.ReadUInt32();
            result.Unknown4 = reader.ReadUInt32();

            return result;
        }

        public static ItemData.NextItemEntry ReadNextItemEntry(BinaryReader reader)
        {
            var nextItemEntry = new ItemData.NextItemEntry();

            nextItemEntry.ItemTdbId = reader.ReadUInt64();
            nextItemEntry.ItemID = reader.ReadUInt32();
            nextItemEntry.UnknownBytes = reader.ReadBytes(3);

            return nextItemEntry;
        }

        public byte[] Write(NodeEntry node, List<INodeParser> parsers)
        {
            byte[] result;
            var data = (ItemData)node.Value;
            using (var stream = new MemoryStream())
            {
                using (var writer = new BinaryWriter(stream, Encoding.ASCII))
                {
                    writer.Write(node.Id);

                    writer.Write(data.ItemTdbId);
                    WriteHeaderThing(writer, data.Header);

                    writer.Write(data.Flags.Raw);
                    writer.Write(data.CreationTime);

                    switch (data.Header.Kind)
                    {
                        case 0:
                            WriteModableItemWithQuantityData(writer, data.Data as ItemData.ModableItemWithQuantityData);
                            break;
                        case 1:
                            WriteSimpleItemData(writer, data.Data as ItemData.SimpleItemData);
                            break;
                        case 2:
                            WriteModableItemData(writer, data.Data as ItemData.ModableItemData);
                            break;
                    }

                    //writer.Write(data.TrailingBytes);
                }
                result = stream.ToArray();
            }

            return result;
        }

        public static void WriteHeaderThing(BinaryWriter writer, ItemData.HeaderThing data)
        {
            writer.Write(data.ItemId);
            writer.Write(data.UnknownBytes1);
            writer.Write(data.UnknownBytes2);
        }

        public static void WriteSimpleItemData(BinaryWriter writer, ItemData.SimpleItemData data)
        {
            writer.Write(data.Quantity);
        }

        public static void WriteModableItemData(BinaryWriter writer, ItemData.ModableItemData data)
        {
            writer.Write(data.TdbId1);
            writer.Write(data.Unknown2);
            writer.Write(data.Unknown3);
            WriteItemModData(writer, data.RootNode);
        }

        public static void WriteModableItemWithQuantityData(BinaryWriter writer, ItemData.ModableItemWithQuantityData data)
        {
            writer.Write(data.Quantity);
            writer.Write(data.TdbId1);
            writer.Write(data.Unknown2);
            writer.Write(data.Unknown3);
            WriteItemModData(writer, data.RootNode);
        }

        public static void WriteItemModData(BinaryWriter writer, ItemData.ItemModData data)
        {
            writer.Write(data.ItemTdbId);
            WriteHeaderThing(writer, data.Header);
            ParserUtils.WriteString(writer, data.UnknownString);
            writer.Write(data.AttachmentSlotTdbId);
            ParserUtils.WritePackedLong(writer, data.ChildrenCount);
            foreach (var kind2DataNode in data.Children)
            {
                WriteItemModData(writer, kind2DataNode);
            }
            writer.Write(data.Unknown2);
            writer.Write(data.TdbId2);
            writer.Write(data.Unknown3);
            writer.Write(data.Unknown4);
        }

        public static void WriteNextItemEntry(BinaryWriter writer, ItemData.NextItemEntry nextItem)
        {
            writer.Write(nextItem.ItemTdbId);
            writer.Write(nextItem.ItemID);
            writer.Write(nextItem.UnknownBytes);
        }
    }
}
