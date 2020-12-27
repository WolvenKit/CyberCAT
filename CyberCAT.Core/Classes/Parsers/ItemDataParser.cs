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
        private const uint MOD_MARKER = 0x7F7FFFFF;

        public string ParsableNodeName { get; private set; }

        public string DisplayName { get; private set; }

        public Guid Guid { get; private set; }

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

            switch (result.Header.Kind)
            {
                case 0:
                    break;
                case 1:
                    result.Data = ReadKind1Data(reader);
                    break;
                case 2:
                    result.Data = ReadKind2Data(reader);
                    break;
            }

            // The item data only goes until node.Size, afterwards
            var toRead = node.Size - (reader.BaseStream.Position - node.Offset);
            Debug.Assert(toRead >= 0);
            result.TrailingBytes = reader.ReadBytes((int)toRead);

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

        public static ItemData.Kind1Data ReadKind1Data(BinaryReader reader)
        {
            var result = new ItemData.Kind1Data();

            result.Flags = new ItemData.ItemFlags(reader.ReadByte());
            result.CreationTime = reader.ReadUInt32();
            result.Unknown2 = reader.ReadUInt32();

            return result;
        }

        public static ItemData.Kind2Data ReadKind2Data(BinaryReader reader)
        {
            var result = new ItemData.Kind2Data();

            result.Flags = new ItemData.ItemFlags(reader.ReadByte());
            result.CreationTime = reader.ReadUInt32();
            result.TdbId1 = reader.ReadUInt64();
            result.Unknown2 = reader.ReadUInt32();
            result.Unknown3 = reader.ReadUInt32();
            result.RootNode = ReadKind2DataNode(reader);

            return result;
        }

        public static ItemData.Kind2DataNode ReadKind2DataNode(BinaryReader reader)
        {
            var result = new ItemData.Kind2DataNode();

            result.ItemTdbId = reader.ReadUInt64();
            result.Header = ReadHeaderThing(reader);
            result.UnknownString = ParserUtils.ReadString(reader);
            result.TdbId1 = reader.ReadUInt64();
            var count = ParserUtils.ReadPackedLong(reader);
            result.Children = new ItemData.Kind2DataNode[count];
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

                    switch (data.Header.Kind)
                    {
                        case 0:
                            break;
                        case 1:
                            WriteKind1Data(writer, data.Data as ItemData.Kind1Data);
                            break;
                        case 2:
                            WriteKind2Data(writer, data.Data as ItemData.Kind2Data);
                            break;
                    }

                    writer.Write(data.TrailingBytes);
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

        public static void WriteKind1Data(BinaryWriter writer, ItemData.Kind1Data data)
        {
            writer.Write(data.Flags.Raw);
            writer.Write(data.CreationTime);
            writer.Write(data.Unknown2);
        }

        public static void WriteKind2Data(BinaryWriter writer, ItemData.Kind2Data data)
        {
            writer.Write(data.Flags.Raw);
            writer.Write(data.CreationTime);
            writer.Write(data.TdbId1);
            writer.Write(data.Unknown2);
            writer.Write(data.Unknown3);
            WriteKind2DataNode(writer, data.RootNode);
        }

        public static void WriteKind2DataNode(BinaryWriter writer, ItemData.Kind2DataNode data)
        {
            writer.Write(data.ItemTdbId);
            WriteHeaderThing(writer, data.Header);
            ParserUtils.WriteString(writer, data.UnknownString);
            writer.Write(data.TdbId1);
            ParserUtils.WritePackedLong(writer, data.ChildrenCount);
            foreach (var kind2DataNode in data.Children)
            {
                WriteKind2DataNode(writer, kind2DataNode);
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
