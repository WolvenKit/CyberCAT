using System;
using System.Collections.Generic;
using System.IO;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class GameAudioParser : INodeParser
    {
        public string ParsableNodeName { get; protected set; }

        public string DisplayName { get; protected set; }

        public Guid Guid { get; protected set; }

        public GameAudioParser()
        {
            ParsableNodeName = Constants.NodeNames.GAME_AUDIO;
            DisplayName = "Game Audio Parser";
            Guid = Guid.Parse("{5969F231-9D03-4D16-B018-C137B55E95E6}");
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