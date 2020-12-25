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

            reader.Skip(4); //skip Id

            result.ItemNameCRC32b = reader.ReadUInt32();
            result.ItemNameLength = reader.ReadByte();

            // Last 7 bytes always are the first 7 bytes of the next item, maybe for consistency?
            // Except for the last item which has 24 bytes at the end

            int readSize = node.TrueSize - ((int) reader.BaseStream.Position - node.Offset);
            result.TrailingBytes = reader.ReadBytes(readSize);

            return result;
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

                    writer.Write(data.ItemNameCRC32b);
                    writer.Write(data.ItemNameLength);

                    writer.Write(data.TrailingBytes);
                }
                result = stream.ToArray();
            }

            return result;
        }
    }
}
