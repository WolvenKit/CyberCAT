using System;
using System.Collections.Generic;
using System.IO;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class QuestDebugLogManagerParser : INodeParser
    {
        public string ParsableNodeName { get; protected set; }

        public string DisplayName { get; protected set; }

        public Guid Guid { get; protected set; }

        public QuestDebugLogManagerParser()
        {
            ParsableNodeName = Constants.NodeNames.QUEST_DEBUG_LOG_MANAGER;
            DisplayName = "Quest Debug Log Manager Parser";
            Guid = Guid.Parse("{22E6EB8A-B47C-4D58-BCED-4332428C62C0}");
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new QuestDebugLogManager();

            reader.Skip(4);
            var text = reader.ReadPackedString();
            result.Lines = text.Split('\n');

            result.Node = node;

            return result;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (QuestDebugLogManager)node.Value;

            var text = string.Join("\n", data.Lines);
            writer.WritePackedString(text);
        }
    }
}