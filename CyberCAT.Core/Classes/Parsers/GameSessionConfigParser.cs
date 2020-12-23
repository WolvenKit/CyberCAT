using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes.Parsers
{
    class GameSessionConfigParser : INodeParser
    {
        public string ParsableNodeName { get; set;}

        public GameSessionConfigParser()
        {
            ParsableNodeName = "off";//Constants.NodeNames.GAME_SESSION_CONFIG_NODE;
        }
        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            if (node.Name != ParsableNodeName)
            {
                throw new Exception("Unexpected SectionName");
            }
            var result = new GameSessionConfig();
            reader.BaseStream.Position = node.Offset;
            reader.Skip(4);//Skip the ID
            result.Hash1 = reader.ReadUInt64();
            result.Hash2 = reader.ReadUInt64();
            var flags = new Flags(reader.ReadByte());
            result.TextValue = reader.ReadString(flags.Length);
            result.Hash3 = reader.ReadUInt64();
            result.TrailingBytes = reader.ReadBytes(node.Size - (29 + flags.Length));
            return result;
        }

        public byte[] Write(NodeEntry node, List<INodeParser> parsers)
        {
            byte[] result;
            var data = (GameSessionConfig)node.Value;
            using(var stream = new MemoryStream())
            {
                using (var writer = new BinaryWriter(stream,Encoding.ASCII))
                {
                    writer.Write(node.Id);
                    writer.Write(data.Hash1);
                    writer.Write(data.Hash2);
                    writer.Write((byte)(data.TextValue.Length+128));
                    writer.Write(Encoding.ASCII.GetBytes(data.TextValue));
                    writer.Write(data.Hash3);
                    writer.Write(data.TrailingBytes);
                }
                result = stream.ToArray();
            }
            node.Size = result.Length;//Add id int size
            return result;
        }
    }
}
