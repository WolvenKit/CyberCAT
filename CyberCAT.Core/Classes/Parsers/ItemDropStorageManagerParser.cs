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
    public class ItemDropStorageManagerParser : INodeParser
    {
        public string ParsableNodeName { get; private set; }

        public string DisplayName { get; private set; }

        public Guid Guid { get; private set; }

        public ItemDropStorageManagerParser()
        {
            ParsableNodeName = Constants.NodeNames.ITEM_DROP_STORAGE_MANAGER;
            DisplayName = "ItemDropStorageManager Parser";
            Guid = Guid.Parse("{79D024AD-2A06-4F03-9652-BA6A3AF03CA2}");
        }
        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new ItemDropStorageManager();
            reader.Skip(4); // Skip Id

            result.NumberOfItemDropStorages = reader.ReadUInt32();
            result.ItemDropStorages = new ItemDropStorage[result.NumberOfItemDropStorages];

            var parser = parsers.FirstOrDefault(p => p.ParsableNodeName==Constants.NodeNames.ITEM_DROP_STORAGE);
            Debug.Assert(parser != null);

            for (var i = 0; i < result.NumberOfItemDropStorages; ++i)
            {
                result.ItemDropStorages[i] = (ItemDropStorage) parser.Read(node.Children[i], reader, parsers);
                node.Children[i].Value = result.ItemDropStorages[i];
            }

            int readSize = node.Size - ((int)reader.BaseStream.Position - node.Offset);
            Debug.Assert(readSize >= 0);
            result.TrailingBytes = reader.ReadBytes(readSize);

            return result;
        }

        public byte[] Write(NodeEntry node, List<INodeParser> parsers)
        {
            byte[] result;
            var data = (ItemDropStorageManager)node.Value;
            using (var stream = new MemoryStream())
            {
                using (var writer = new BinaryWriter(stream, Encoding.ASCII))
                {
                    writer.Write(node.Id);
                    writer.Write(data.NumberOfItemDropStorages);

                    var parser = parsers.FirstOrDefault(p => p.ParsableNodeName==Constants.NodeNames.ITEM_DROP_STORAGE);
                    Debug.Assert(parser != null);

                    for (var i = 0; i < data.NumberOfItemDropStorages; ++i)
                    {
                        writer.Write(parser.Write(node.Children[i], parsers));
                    }

                    writer.Write(data.TrailingBytes);
                }
                result = stream.ToArray();
            }
            return result;
        }
    }
}
