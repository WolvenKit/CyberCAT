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
    class InventoryParser : INodeParser
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

            result.HeaderBytes = reader.ReadBytes(4 + 8);
            result.NumberOfItems = reader.ReadUInt32();

            int readSize = node.TrueSize - ((int)reader.BaseStream.Position - node.Offset);
            result.TrailingBytes = reader.ReadBytes(readSize);

            if (node.Children.Count > 0)
            {
                foreach (var child in node.Children)
                {
                    var parser = parsers.Where(p => p.ParsableNodeName == child.Name).FirstOrDefault();
                    if (parser != null)
                    {
                        child.Value = parser.Read(child, reader, parsers);
                    }
                    else
                    {
                        var fallback = new DefaultParser();
                        child.Value = fallback.Read(child, reader, parsers);
                    }
                }
            }

            return result;
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
                    
                    writer.Write(data.HeaderBytes);

                    if (data.NumberOfItems != node.Children.Count)
                    {
                        data.NumberOfItems = (uint) node.Children.Count;
                    }

                    writer.Write(data.NumberOfItems);

                    writer.Write(data.TrailingBytes);

                    // Inventory should not have anything other than itemData in it.
                    var parser = parsers.FirstOrDefault(p => p.ParsableNodeName == Constants.NodeNames.ITEM_DATA);
                    Debug.Assert(parser != null);

                    foreach (var child in node.Children)
                    {
                        Debug.Assert(child.Name == "itemData");
                        writer.Write(parser.Write(child, parsers));
                    }
                }
                result = stream.ToArray();
            }
            return result;
        }
    }
}
