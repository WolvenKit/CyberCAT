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
            ParsableNodeName = Constants.NodeNames.GAME_SESSION_CONFIG_NODE;
        }
        public object Parse(NodeEntry node, BinaryReader reader)
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
    }
}
