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
        public string ParsableNodeName { get; }

        public string DisplayName { get; }

        public Guid Guid { get; }

        public FactsDBParser()
        {
            ParsableNodeName = Constants.NodeNames.FACTSDB;
            DisplayName = "FactsDB Parser";
            Guid = Guid.Parse("{DC81E697-3C6F-46D8-A482-D80469E8BD78}");
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            node.Parser = this;
            reader.Skip(4);

            var result = new FactsDB();
            var count = reader.ReadByte();

            // There should be count many children
            if (count != node.Children.Count)
            {
                throw new InvalidDataException($"Expected {count} FactsTable but found {node.Children.Count}.");
            }

            var parser = parsers.Where(p => p.ParsableNodeName == Constants.NodeNames.FACTS_TABLE).FirstOrDefault();
            Debug.Assert(parser != null);

            foreach (var child in node.Children)
            {
                child.Value = (FactsTable) parser.Read(child, reader, parsers);
                result.FactsTables.Add((FactsTable) child.Value);
            }

            // There is a blob between the last factstable and the next node in questsystem
            result.TrailingBytes = reader.ReadBytes(node.TrailingSize);

            result.Node = node;

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

                    if (data.FactsTableCount != node.Children.Count)
                    {
                        throw new InvalidDataException($"Expected {data.FactsTableCount} FactsTable but found {node.Children.Count}.");
                    }

                    writer.Write(data.FactsTableCount);

                    var parser = parsers.Where(p => p.ParsableNodeName == Constants.NodeNames.FACTS_TABLE).FirstOrDefault();
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
