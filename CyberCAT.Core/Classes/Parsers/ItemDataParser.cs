using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberCAT.Core.Classes.Interfaces;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class ItemDataParser : INodeParser
    {
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
            result.ItemNameLength = BitConverter.GetBytes(result.ItemTdbId)[4];
            result.ItemID = reader.ReadUInt32();
            result.UnknownBytes2 = reader.ReadBytes(8);
            result.ItemQuantity = reader.ReadUInt32();

            if (result.ItemID != 2)
            {
                result.UnknownBytes3 = reader.ReadBytes(40);

                var modCount = reader.ReadByte();
                result.ModEntries = new ItemData.ModEntry[modCount];
                for (int i = 0; i < modCount; i++)
                {
                    result.ModEntries[i] = new ItemData.ModEntry();
                    result.ModEntries[i].ItemTdbId = reader.ReadUInt64();
                    result.ModEntries[i].ItemNameLength = BitConverter.GetBytes(result.ModEntries[i].ItemTdbId)[4];
                    result.ModEntries[i].ItemID = reader.ReadUInt32();
                    result.ModEntries[i].UnknownBytes2 = reader.ReadBytes(37);
                }
            }

            // The item data only goes until node.Size, afterwards
            var toRead = node.Size - (reader.BaseStream.Position - node.Offset);

            result.ItemDataBytes = reader.ReadBytes((int)toRead);

            // Last 7 bytes always are the first 7 bytes of the next item, maybe for consistency?
            // Except for the last item which has 24 bytes at the end

            int readSize = node.TrueSize - ((int) reader.BaseStream.Position - node.Offset);
            result.TrailingBytes = reader.ReadBytes(readSize);

            return result;
        }

        public static ItemData.NextItemEntry ReadNextItemEntry(BinaryReader reader)
        {
            var nextItemEntry = new ItemData.NextItemEntry();

            nextItemEntry.ItemTdbId = reader.ReadUInt64();
            nextItemEntry.ItemNameLength = BitConverter.GetBytes(nextItemEntry.ItemTdbId)[4];
            nextItemEntry.ItemID = reader.ReadUInt32();
            nextItemEntry.UnknownBytes2 = reader.ReadBytes(3);

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
                    writer.Write(data.ItemNameLength);
                    writer.Write(new byte[] { 0, 0, 0 });
                    writer.Write(data.ItemID);
                    writer.Write(data.UnknownBytes2);
                    writer.Write(data.ItemQuantity);

                    if (data.ItemID != 2)
                    {
                        writer.Write(data.UnknownBytes3);
                        writer.Write((byte)data.ModEntries.Length);

                        for (int i = 0; i < data.ModEntries.Length; i++)
                        {
                            writer.Write(data.ModEntries[i].ItemTdbId);
                            writer.Write(data.ModEntries[i].ItemNameLength);
                            writer.Write(new byte[] {0,0,0});
                            writer.Write(data.ModEntries[i].ItemID);
                            writer.Write(data.ModEntries[i].UnknownBytes2);
                        }
                    }

                    writer.Write(data.ItemDataBytes);

                    writer.Write(data.TrailingBytes);
                }
                result = stream.ToArray();
            }

            return result;
        }

        public static void WriteNextItemEntry(BinaryWriter writer, ItemData.NextItemEntry nextItem)
        {
            writer.Write(nextItem.ItemTdbId);
            writer.Write(nextItem.ItemNameLength);
            writer.Write(new byte[] { 0, 0, 0 });
            writer.Write(nextItem.ItemID);
            writer.Write(nextItem.UnknownBytes2);
        }
    }
}
