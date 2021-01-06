using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class InventoryParser : INodeParser
    {
        public string ParsableNodeName { get; private set; }

        public string DisplayName { get; private set; }

        public Guid Guid { get; private set; }

        public InventoryParser()
        {
            ParsableNodeName = Constants.NodeNames.INVENTORY;
            DisplayName = "Inventory Parser";
            Guid = Guid.Parse("{2B294EE8-E791-4D9F-A40A-1EF3F516A4A8}");
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            node.Parser = this;
            var result = new Inventory();

            reader.Skip(4); //skip Id
            var count = reader.ReadUInt32();

            var offset = 0u;
            for (var i = 0; i < count; ++i)
            {
                var subInventory = ReadSubInventory(node, offset, reader, parsers);
                result.SubInventories.Add(subInventory);
                offset += subInventory.NumberOfItems;
            }

            result.Node = node;
            return result;
        }

        public static Inventory.SubInventory ReadSubInventory(NodeEntry inventoryNode, uint nodeOffset, BinaryReader reader, List<INodeParser> parsers)
        {
            var subInventory = new Inventory.SubInventory();

            subInventory.InventoryId = reader.ReadUInt64();
            var count = reader.ReadUInt32();

            var parser = parsers.Where(p => p.ParsableNodeName == Constants.NodeNames.ITEM_DATA).FirstOrDefault();
            Debug.Assert(parser != null);

            for (var i = 0; i < count; ++i)
            {
                var nextItemHeader = ItemDataParser.ReadNextItemEntry(reader);
                var item = (ItemData) parser.Read(inventoryNode.Children[(int)nodeOffset + i], reader, parsers);

                if (!nextItemHeader.BelongsToItemData(item))
                {
                    throw new InvalidDataException($"Expected next item to be '{nextItemHeader}' but found '{item}'");
                }

                subInventory.Items.Add(item);

                inventoryNode.Children[(int) nodeOffset + i].Value = item;
            }

            return subInventory;
        }

        public byte[] Write(NodeEntry node, List<INodeParser> parsers, int parentHeaderSize)
        {
            byte[] result;
            var data = (Inventory)node.Value;
            using (var stream = new MemoryStream())
            {
                using (var writer = new BinaryWriter(stream, Encoding.ASCII))
                {
                    writer.Write(node.Id);
                    writer.Write(data.NumberOfInventories);
                    var offset = 0u;
                    var bytesBefore = 4 + 4;
                    for (var i = 0; i < data.NumberOfInventories; ++i)
                    {
                        WriteSubInventory(node, offset, bytesBefore, writer, data.SubInventories[i], parsers);
                        if (data.SubInventories[i].Items.Count == 0)
                        {
                            bytesBefore += 8 + 4;
                        }
                        else
                        {
                            bytesBefore = 0;
                        }
                        offset += data.SubInventories[i].NumberOfItems;
                    }
                }
                result = stream.ToArray();
            }

            return result;
        }

        public static void WriteSubInventory(NodeEntry inventoryNode, uint nodeOffset, int bytesBefore, BinaryWriter writer, Inventory.SubInventory subInventory, List<INodeParser> parsers)
        {
            writer.Write(subInventory.InventoryId);
            writer.Write(subInventory.NumberOfItems);

            var parser = parsers.Where(p => p.ParsableNodeName == Constants.NodeNames.ITEM_DATA).FirstOrDefault();
            Debug.Assert(parser != null);

            for (var i = 0; i < subInventory.NumberOfItems; ++i)
            {
                var nextItem = subInventory.Items[i];
                ItemDataParser.WriteNextItemEntryFromItem(writer, nextItem);
                var buffer = parser.Write(inventoryNode.Children[(int) nodeOffset + i], parsers, 0);
                writer.Write(buffer);
            }
        }
    }
}
