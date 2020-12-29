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
    public class FactsDBParser : INodeParser
    {
        public List<string> ParsableNodeNames { get; private set; }

        public string DisplayName { get; }

        public Guid Guid { get; }

        public FactsDBParser()
        {
            ParsableNodeNames = new List<string>
            {
                Constants.NodeNames.FACTSDB
            };
            DisplayName = "FactsDB Parser";
            Guid = Guid.Parse("{DC81E697-3C6F-46D8-A482-D80469E8BD78}");
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            reader.Skip(4);

            var result = new FactsDB();
            result.FactsTableCount = reader.ReadByte();

            ParserUtils.ParseChildren(node.Children, reader, parsers);

            // There is a blob between the last factstable and the next node in questsystem
            var nextNode = node.GetNextNode();
            var toRead = nextNode.Offset - reader.BaseStream.Position;
            Debug.Assert(toRead >= 0);
            result.TrailingBytes = reader.ReadBytes((int)toRead);

            return result;
        }

        public byte[] Write(NodeEntry node, List<INodeParser> parsers)
        {
            byte[] result;
            var data = (FactsDB)node.Value;
            using (var stream = new MemoryStream())
            {
                using (var writer = new BinaryWriter(stream, Encoding.ASCII))
                {
                    writer.Write(node.Id);
                    writer.Write(data.FactsTableCount);

                    var parser = parsers.FirstOrDefault(p => p.ParsableNodeNames.Contains(Constants.NodeNames.FACTS_TABLE));
                    Debug.Assert(parser != null);

                    foreach (var child in node.Children)
                    {
                        writer.Write(parser.Write(child, parsers));
                    }
                   
                    writer.Write(data.TrailingBytes);
                }
                result = stream.ToArray();
            }
            return result;
        }
    }
}
