using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class ItemDropStorageParser :INodeParser
    {
        public string ParsableNodeName { get; private set; }

        public string DisplayName { get; private set; }

        public Guid Guid { get; private set; }

        public ItemDropStorageParser()
        {
            ParsableNodeName = Constants.NodeNames.ITEM_DROP_STORAGE;
            DisplayName = "ItemDropStorage Parser";
            Guid = Guid.Parse("{417FE6C4-A916-4C9C-86B9-AD73C9D3B50D}");
        }
        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new ItemDropStorage();

            reader.Skip(4); // Skip Id

            result.UnknownString = ParserUtils.ReadString(reader);
            result.HeaderBytes = reader.ReadBytes(25);
            result.Inventory = InventoryParser.ReadSubInventory(node, 0, reader, parsers);

            return result;
        }

        public byte[] Write(NodeEntry node, List<INodeParser> parsers)
        {
            byte[] result;
            var data = (ItemDropStorage)node.Value;
            using (var stream = new MemoryStream())
            {
                using (var writer = new BinaryWriter(stream, Encoding.ASCII))
                {
                    writer.Write(node.Id);
                    ParserUtils.WriteString(writer, data.UnknownString);
                    writer.Write(data.HeaderBytes);
                    InventoryParser.WriteSubInventory(node, 0, writer, data.Inventory, parsers);
                }
                result = stream.ToArray();
            }
            return result;
        }
    }
}
