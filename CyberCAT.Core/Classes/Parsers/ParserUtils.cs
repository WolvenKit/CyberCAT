using System.Collections.Generic;
using System.IO;
using System.Linq;
using CyberCAT.Core.Classes.Interfaces;

namespace CyberCAT.Core.Classes.Parsers
{
    internal class ParserUtils
    {
        public static void ParseChildren(IEnumerable<NodeEntry> children, BinaryReader reader, List<INodeParser> parsers)
        {
            foreach (var node in children)
            {
                reader.BaseStream.Position = node.Offset;
                var parser = parsers.FirstOrDefault(p => p.ParsableNodeName == node.Name) ?? new DefaultParser();
                node.Value = parser.Read(node, reader, parsers);
                node.Parser = parser;
            }
        }
    }
}