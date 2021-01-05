using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CyberCAT.Core.Classes.Parsers
{
    public class DefaultParser : INodeParser
    {
        public string DisplayName { get; }
        public Guid Guid { get; }
        public string ParsableNodeName { get; }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            reader.Skip(4); // Skip Id
            var result = new DefaultRepresentation();
            result.HeaderBlob = reader.ReadBytes(node.DataSize - 4);

            ParserUtils.ParseChildren(node.Children, reader, parsers);

            Debug.Assert(node.TrailingSize >= 0);
            result.TrailingBlob = reader.ReadBytes(node.TrailingSize);

            result.Node = node;

            return result;
        }

        public byte[] Write(NodeEntry node, List<INodeParser> parsers, int parentHeaderSize)
        {
            byte[] result;
            var data = (DefaultRepresentation)node.Value;
            using (var stream = new MemoryStream())
            {
                using (var writer = new BinaryWriter(stream, Encoding.ASCII))
                {
                    writer.Write(node.Id);
                    writer.Write(data.HeaderBlob);

                    if (node.Children.Count > 0)
                    {
                        var first = true;
                        foreach (var child in node.Children)
                        {
                            var parser = parsers.Where(p => p.ParsableNodeName == child.Name).FirstOrDefault();
                            if (parser == null)
                            {
                                parser = new DefaultParser();
                            }
                            writer.Write(parser.Write(child, parsers, first ? (int)writer.BaseStream.Position : 0));
                            first = false;
                        }
                    }

                    writer.Write(data.TrailingBlob);
                }
                result = stream.ToArray();
            }

            return result;
        }
    }
}
