using System;
using System.Collections.Generic;
using System.IO;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class RadioSystemParser : INodeParser
    {
        public string ParsableNodeName { get; protected set; }

        public string DisplayName { get; protected set; }

        public Guid Guid { get; protected set; }

        public RadioSystemParser()
        {
            ParsableNodeName = Constants.NodeNames.RADIO_SYSTEM;
            DisplayName = "Radio System Parser";
            Guid = Guid.Parse("{B794F297-3AF2-4CD6-BC19-AEF7FA994028}");
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new RadioSystem();

            reader.Skip(4);
            result.Unknown = reader.ReadPackedString();

            result.Node = node;

            return result;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (RadioSystem)node.Value;

            writer.WritePackedString(data.Unknown);
        }
    }
}