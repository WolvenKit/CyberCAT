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

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (DefaultRepresentation)node.Value;

            writer.Write(data.HeaderBlob);

            if (node.Children.Count > 0)
            {
                foreach (var child in node.Children)
                {
                    writer.Write(child);
                }
            }

            writer.Write(data.TrailingBlob);
        }
    }
}
