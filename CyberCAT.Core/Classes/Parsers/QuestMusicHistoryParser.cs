using System;
using System.Collections.Generic;
using System.IO;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class QuestMusicHistoryParser : INodeParser
    {
        public string ParsableNodeName { get; protected set; }

        public string DisplayName { get; protected set; }

        public Guid Guid { get; protected set; }

        public QuestMusicHistoryParser()
        {
            ParsableNodeName = Constants.NodeNames.QUEST_MUSIC_HISTORY;
            DisplayName = "Quest Music History Parser";
            Guid = Guid.Parse("{D72A1640-C077-47F3-83E7-817B7305172D}");
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new QuestMusicHistory();

            reader.Skip(4);
            var count = reader.ReadUInt32();
            for (int i = 0; i < count; i++)
            {
                var entry = new QuestMusicHistory.Entry();

                entry.Unknown1 = reader.ReadTweakDbId();
                entry.Unknown2 = reader.ReadUInt64();
                entry.Unknown3 = reader.ReadUInt64();
                entry.Unknown4 = reader.ReadUInt16();
                entry.Unknown5 = reader.ReadUInt16();
                entry.Unknown6 = reader.ReadUInt32();

                result.Entries.Add(entry);
            }

            result.Node = node;

            return result;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (QuestMusicHistory)node.Value;

            writer.Write(data.Entries.Count);
            foreach (var entry in data.Entries)
            {
                writer.Write(entry.Unknown1);
                writer.Write(entry.Unknown2);
                writer.Write(entry.Unknown3);
                writer.Write(entry.Unknown4);
                writer.Write(entry.Unknown5);
                writer.Write(entry.Unknown6);
            }
        }
    }
}