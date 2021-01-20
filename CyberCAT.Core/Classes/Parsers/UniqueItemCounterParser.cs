using System;
using System.Collections.Generic;
using System.IO;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class UniqueItemCounterParser : INodeParser
    {
        public string ParsableNodeName { get; protected set; }

        public string DisplayName { get; protected set; }

        public Guid Guid { get; protected set; }

        public UniqueItemCounterParser()
        {
            ParsableNodeName = Constants.NodeNames.UNIQUE_ITEM_COUNTER;
            DisplayName = "Unique Item Counter Parser";
            Guid = Guid.Parse("{34C6DF35-1C9C-4A3F-8892-0C42C1E6D923}");
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new UniqueItemCounter();

            reader.Skip(4);
            result.Count = reader.ReadUInt16();

            result.Node = node;

            return result;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (UniqueItemCounter)node.Value;

            writer.Write(data.Count);
        }
    }
}