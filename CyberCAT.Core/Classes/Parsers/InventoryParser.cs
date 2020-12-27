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
            var result = new Inventory();

            reader.Skip(4); //skip Id
            result.NumberOfInventories = reader.ReadUInt32();

            result.SubInventories = new Inventory.SubInventory[result.NumberOfInventories];
            var offset = 0u;
            for (var i = 0; i < result.NumberOfInventories; ++i)
            {
                result.SubInventories[i] = ReadSubInventory(node, offset, reader, parsers);
                offset += result.SubInventories[i].NumberOfItems;
            }

            return result;
        }

        private Inventory.SubInventory ReadSubInventory(NodeEntry inventoryNode, uint nodeOffset, BinaryReader reader, List<INodeParser> parsers)
        {
            var subInventory = new Inventory.SubInventory();

            subInventory.InventoryId = reader.ReadUInt64();
            subInventory.NumberOfItems = reader.ReadUInt32();

            subInventory.ItemHeaders = new ItemData.NextItemEntry[subInventory.NumberOfItems];
            subInventory.Items = new ItemData[subInventory.NumberOfItems];
            var parser = parsers.Where(p => p.ParsableNodeName == Constants.NodeNames.ITEM_DATA).FirstOrDefault();
            Debug.Assert(parser != null);

            for (var i = 0; i < subInventory.NumberOfItems; ++i)
            {
                subInventory.ItemHeaders[i] = ItemDataParser.ReadNextItemEntry(reader);
                subInventory.Items[i] = (ItemData) parser.Read(inventoryNode.Children[(int)nodeOffset + i], reader, parsers);
                inventoryNode.Children[(int) nodeOffset + i].Value = subInventory.Items[i];
            }

            return subInventory;
        }

        public byte[] Write(NodeEntry node, List<INodeParser> parsers)
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
                    for (var i = 0; i < data.NumberOfInventories; ++i)
                    {
                        WriteSubInventory(node, offset, writer, data.SubInventories[i], parsers);
                        offset += data.SubInventories[i].NumberOfItems;
                    }
                }
                result = stream.ToArray();
            }
            return result;
        }

        public void WriteSubInventory(NodeEntry inventoryNode, uint nodeOffset, BinaryWriter writer, Inventory.SubInventory subInventory, List<INodeParser> parsers)
        {
            writer.Write(subInventory.InventoryId);
            writer.Write(subInventory.NumberOfItems);

            var parser = parsers.Where(p => p.ParsableNodeName == Constants.NodeNames.ITEM_DATA).FirstOrDefault();
            Debug.Assert(parser != null);

            for (var i = 0; i < subInventory.NumberOfItems; ++i)
            {
                ItemDataParser.WriteNextItemEntry(writer, subInventory.ItemHeaders[i]);
                writer.Write(parser.Write(inventoryNode.Children[(int) nodeOffset + i], parsers));
            }
        }
    }
}
