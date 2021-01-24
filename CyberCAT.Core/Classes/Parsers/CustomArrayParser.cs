using System;
using System.Collections.Generic;
using System.IO;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class CustomArrayParser : INodeParser
    {
        public string ParsableNodeName { get; }

        public string DisplayName { get; }

        public Guid Guid { get; }

        public CustomArrayParser()
        {
            ParsableNodeName = Constants.NodeNames.CUSTOM_ARRAY;
            DisplayName = "Custom Array Parser";
            Guid = Guid.Parse("{AE82C4DA-05B6-47D8-A67E-2DAE559EE47C}");
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new CustomArray();

            reader.Skip(4); // Skip Id
            var entryCount = reader.ReadUInt32();
            for (int i = 0; i < entryCount; i++)
            {
                result.Unknown.Add(reader.ReadUInt16());
            }

            int readSize = node.Size - ((int)reader.BaseStream.Position - node.Offset);

            result.Node = node;

            return result;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (CustomArray)node.Value;

            writer.Write(data.Unknown.Count);
            foreach (var entry in data.Unknown)
            {
                writer.Write(entry);
            }
        }
    }
}