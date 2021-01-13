using System;
using System.Collections.Generic;
using System.IO;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class DirectorSystemParser : INodeParser
    {
        public string ParsableNodeName { get; protected set; }

        public string DisplayName { get; protected set; }

        public Guid Guid { get; protected set; }

        public DirectorSystemParser()
        {
            ParsableNodeName = Constants.NodeNames.DIRECTOR_SYSTEM;
            DisplayName = "Director System Parser";
            Guid = Guid.Parse("{97953190-62C6-4865-BD4D-9D8F9602B1EC}");
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new DirectorSystem();

            reader.Skip(4);
            result.Unknown1 = reader.ReadUInt32();
            result.Unknown2 = ParserUtils.ReadString(reader);
            result.Unknown3 = reader.ReadByte();
            result.Unknown4 = ParserUtils.ReadString(reader);
            result.Unknown5 = reader.ReadUInt32();

            result.Node = node;

            return result;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (DirectorSystem)node.Value;

            writer.Write(data.Unknown1);
            ParserUtils.WriteString(writer, data.Unknown2);
            writer.Write(data.Unknown3);
            ParserUtils.WriteString(writer, data.Unknown4);
            writer.Write(data.Unknown5);
        }
    }
}