using System;
using System.Collections.Generic;
using System.IO;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class MusicSystemParser : INodeParser
    {
        public string ParsableNodeName { get; protected set; }

        public string DisplayName { get; protected set; }

        public Guid Guid { get; protected set; }

        public MusicSystemParser()
        {
            ParsableNodeName = Constants.NodeNames.MUSIC_SYSTEM;
            DisplayName = "Music System Parser";
            Guid = Guid.Parse("{8BFBAF28-77A9-4C70-8928-B9424641434C}");
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new MusicSystem();

            reader.Skip(4);
            result.Unknown1 = ParserUtils.ReadString(reader);
            if (result.Unknown1 != "None")
            {
                result.Unknown2 = ParserUtils.ReadString(reader);
                result.Unknown3 = reader.ReadByte();
                result.Unknown4 = ParserUtils.ReadString(reader);
                result.Unknown5 = ParserUtils.ReadString(reader);
                result.Unknown6 = reader.ReadUInt16();
                result.Unknown7 = ParserUtils.ReadString(reader);
                result.Unknown8 = reader.ReadUInt32();
            }

            result.Node = node;

            return result;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (MusicSystem)node.Value;

            ParserUtils.WriteString(writer, data.Unknown1);
            if (data.Unknown1 != "None")
            {
                ParserUtils.WriteString(writer, data.Unknown2);
                writer.Write(data.Unknown3);
                ParserUtils.WriteString(writer, data.Unknown4);
                ParserUtils.WriteString(writer, data.Unknown5);
                writer.Write(data.Unknown6);
                ParserUtils.WriteString(writer, data.Unknown7);
                writer.Write(data.Unknown8);
            }
        }
    }
}