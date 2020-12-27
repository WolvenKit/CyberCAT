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
            result.ItemID = reader.ReadUInt32();
            result.UnknownBytes1 = reader.ReadBytes(3);
            result.Flags1 = (ItemData.Flag1) reader.ReadByte();
            result.CreationTime = reader.ReadUInt32();
            result.ItemQuantity = reader.ReadUInt32();

            if (result.ItemID != 2)
            {
                // Mods don't seem to have a length field but are escaped by FFFF7F7F markers
                result.UnknownBytes3 = reader.ReadBytes(8);

                // First, consume 4 bytes and see if we got the marker
                var potentialMarker = reader.ReadUInt32();
                if (potentialMarker == MOD_MARKER)
                {
                    while (true)
                    {
                        // We have one, so consume a mod entry.
                        result.ModEntries.Add(ReadModEntry(reader));
                        // Now, another marker should follow.
                        potentialMarker = reader.ReadUInt32();
                        Debug.Assert(potentialMarker == MOD_MARKER);
                        // If there is space left, consume another mod marker
                        var left = node.Size - (reader.BaseStream.Position - node.Offset);
                        if (left > 0)
                        {
                            continue;
                        }
                        // Otherwise, this item is done.
                        break;
                    }
                }
                else
                {
                    reader.BaseStream.Position -= 4;
                }
            }

            // The item data only goes until node.Size, afterwards
            var toRead = node.Size - (reader.BaseStream.Position - node.Offset);
            Debug.Assert(toRead >= 0);
            result.ItemDataBytes = reader.ReadBytes((int)toRead);

            // Last 7 bytes always are the first 7 bytes of the next item, maybe for consistency?
            // Except for the last item which has 24 bytes at the end

            int readSize = node.TrueSize - ((int) reader.BaseStream.Position - node.Offset);
            Debug.Assert(readSize >= 0);
            result.TrailingBytes = reader.ReadBytes(readSize);

            return result;
        }

        public static ItemData.NextItemEntry ReadNextItemEntry(BinaryReader reader)
        {
            var nextItemEntry = new ItemData.NextItemEntry();

            nextItemEntry.ItemTdbId = reader.ReadUInt64();
            nextItemEntry.ItemID = reader.ReadUInt32();
            nextItemEntry.UnknownBytes2 = reader.ReadBytes(3);

            return nextItemEntry;
        }

        private ItemData.ModEntry ReadModEntry(BinaryReader reader)
        {
            var modEntry = new ItemData.ModEntry();
            modEntry.ItemTdbId = reader.ReadUInt64();
            modEntry.ItemID = reader.ReadUInt32();
            modEntry.UnknownBytes2 = reader.ReadBytes(3);

            // We need to look into the future. If there is a MOD_MARKER 16 bytes from the first one, then the entry is done.
            reader.ReadByte(); // Discard one byte, now we have read 16 bytes.
            var potentialMarker = reader.ReadUInt32();
            if (potentialMarker == MOD_MARKER)
            {
                modEntry.UnknownString = null;
                reader.BaseStream.Position -= 1 + 4;
                modEntry.UnknownBytes3 = reader.ReadBytes(1);
                // We are done here.
                return modEntry;
            }
            reader.BaseStream.Position -= 1 + 4;

            // otherwise, there should now be a string here.
            modEntry.UnknownString = ParserUtils.ReadString(reader);

            // Find the MOD_MARKER for the end.
            var previousPosition = (int)reader.BaseStream.Position;
            uint marker = 0;
            while (marker != MOD_MARKER)
            {
                marker >>= 8;
                marker |= ((uint)reader.ReadByte() << 24);
            }

            var skippedBytes = (int)reader.BaseStream.Position - previousPosition;
            reader.BaseStream.Position = previousPosition;
            modEntry.UnknownBytes3 = reader.ReadBytes(skippedBytes - 4);

            return modEntry;
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
                    writer.Write(data.ItemID);
                    writer.Write(data.UnknownBytes1);
                    writer.Write((byte) data.Flags1);
                    writer.Write(data.CreationTime);
                    writer.Write(data.ItemQuantity);

                    if (data.ItemID != 2)
                    {
                        writer.Write(data.UnknownBytes3);

                        if (data.ModEntries.Count > 0)
                        {
                            writer.Write(MOD_MARKER);
                        }
                        foreach (var modEntry in data.ModEntries)
                        {
                            WriteModEntry(writer, modEntry);
                        }
                    }

                    writer.Write(data.ItemDataBytes);

                    writer.Write(data.TrailingBytes);
                }
                result = stream.ToArray();
            }

            return result;
        }

        private void WriteModEntry(BinaryWriter writer, ItemData.ModEntry modEntry)
        {
            writer.Write(modEntry.ItemTdbId);
            writer.Write(modEntry.ItemID);
            writer.Write(modEntry.UnknownBytes2);

            if (modEntry.UnknownString == null)
            {
                // This is a 16byte modEntry.
                writer.Write(modEntry.UnknownBytes3);
                writer.Write(MOD_MARKER);
                return;
            }

            ParserUtils.WriteString(writer, modEntry.UnknownString);
            writer.Write(modEntry.UnknownBytes3);
            writer.Write(MOD_MARKER);
        }

        public static void WriteNextItemEntry(BinaryWriter writer, ItemData.NextItemEntry nextItem)
        {
            writer.Write(nextItem.ItemTdbId);
            writer.Write(nextItem.ItemID);
            writer.Write(nextItem.UnknownBytes2);
        }
    }
}
