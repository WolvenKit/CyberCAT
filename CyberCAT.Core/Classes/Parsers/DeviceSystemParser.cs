using System;
using System.Collections.Generic;
using System.IO;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class DeviceSystemParser : INodeParser
    {
        public string ParsableNodeName { get; protected set; }

        public string DisplayName { get; protected set; }

        public Guid Guid { get; protected set; }

        public DeviceSystemParser()
        {
            ParsableNodeName = Constants.NodeNames.DEVICE_SYSTEM;
            DisplayName = "Device System Parser";
            Guid = Guid.Parse("{8D42103B-D475-4279-B898-F9A4C5349F79}");
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            ParserUtils.ParseChildren(node.Children, reader, parsers);

            return new NodeRepresentation { Node = node };
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            foreach (var child in node.Children)
            {
                writer.Write(child);
            }
        }
    }
}