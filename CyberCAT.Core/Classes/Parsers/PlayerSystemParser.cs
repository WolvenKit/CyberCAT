using System;
using System.Collections.Generic;
using System.IO;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class PlayerSystemParser : INodeParser
    {
        public string ParsableNodeName { get; }

        public string DisplayName { get; }

        public Guid Guid { get; }

        public PlayerSystemParser()
        {
            ParsableNodeName = Constants.NodeNames.PLAYER_SYSTEM;
            DisplayName = "Player System Parser";
            Guid = Guid.Parse("{00ACE071-51A0-44AC-B41D-44813780E5EE}");
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new PlayerSystem();

            reader.Skip(4); // Skip Id
            result.Unk_Hash = reader.ReadUInt64();
            result.Unk_Id = reader.ReadTweakDbId();

            result.Node = node;

            return result;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (PlayerSystem)node.Value;

            writer.Write(data.Unk_Hash);
            writer.Write(data.Unk_Id);
        }
    }
}