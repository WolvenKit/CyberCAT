using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberCAT.Core.Classes.Interfaces;

namespace CyberCAT.Core.Classes.Parsers
{
    class ParserUtils
    {
        public static string ReadString(BinaryReader reader, out Flags flags)
        {
            flags = new Flags(reader.ReadByte());
            return reader.ReadString(flags.Length);
        }

        public static string ReadString(BinaryReader reader)
        {
            var flags = new Flags(reader.ReadByte());
            return reader.ReadString(flags.Length);
        }

        public static void ParseChildren(IEnumerable<NodeEntry> children, BinaryReader reader, List<INodeParser> parsers)
        {
            foreach (var node in children)
            {
                reader.BaseStream.Position = node.Offset;
                var parser = parsers.Where(p => p.ParsableNodeName == node.Name).FirstOrDefault();
                if (parser != null)
                {
                    node.Value = parser.Read(node, reader, parsers);
                }
                else
                {
                    var fallback = new DefaultParser();
                    node.Value = fallback.Read(node, reader, parsers);
                }
            }
        }
    }
}
