using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class FactsTableParser : INodeParser
    {
        public string ParsableNodeName { get; }

        public string DisplayName { get; }

        public Guid Guid { get; }

        public FactsTableParser()
        {
            ParsableNodeName = Constants.NodeNames.FACTS_TABLE;
            DisplayName = "FactsTable Parser";
            Guid = Guid.Parse("{9C547EAE-3993-4A7E-9732-F7CF24942BC0}");
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            node.Parser = this;
            var result = new FactsTable();

            reader.Skip(4); //skip Id

            var count = ParserUtils.ReadPackedLong(reader);

            var tmpFactList = new uint[count];
            for (int i = 0; i < count; i++)
            {
                tmpFactList[i] = reader.ReadUInt32();
            }

            for (int i = 0; i < count; i++)
            {
                result.FactEntries.Add(new FactsTable.FactEntry
                {
                    Hash = tmpFactList[i],
                    Value = reader.ReadUInt32()
                });
            }

            ParserUtils.ParseChildren(node.Children, reader, parsers);

            result.Node = node;
            return result;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (FactsTable)node.Value;

            ParserUtils.WritePackedLong(writer, data.FactEntries.Count);

            foreach (var fact in data.FactEntries)
            {
                writer.Write(fact.Hash);
            }

            foreach (var fact in data.FactEntries)
            {
                writer.Write(fact.Value);
            }
        }
    }
}