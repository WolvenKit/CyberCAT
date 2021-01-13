using System;
using System.Collections.Generic;
using System.IO;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class JournalManagerParser : INodeParser
    {
        public string ParsableNodeName { get; }

        public string DisplayName { get; }

        public Guid Guid { get; }

        public JournalManagerParser()
        {
            ParsableNodeName = Constants.NodeNames.JOURNAL_MANAGER;
            DisplayName = "Journal Manager Parser";
            Guid = Guid.Parse("{ABA70F10-BFEC-4C39-8578-7D4D42923DCE}");
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new JournalManager();

            reader.Skip(4); // Skip Id
            var entryCount = reader.ReadUInt32();
            for (int i = 0; i < entryCount; i++)
            {
                var entry = new JournalManager.Entry1();
                entry.Unk1_PathHash = reader.ReadUInt32();
                entry.Unk2_State = reader.ReadUInt32();
                entry.Unknown3 = reader.ReadUInt32();
                entry.Unknown4 = reader.ReadUInt32();

                result.Entries.Add(entry);
            }

            result.Unk1_TrackedQuestPath = reader.ReadUInt32();

            entryCount = reader.ReadUInt32();
            for (int i = 0; i < entryCount; i++)
            {
                // could be wrong, strings with length 2?
                result.Unknown2.Add(reader.ReadTweakDbId());
            }

            entryCount = reader.ReadUInt32();
            for (int i = 0; i < entryCount; i++)
            {
                var entry = new JournalManager.Entry2();
                entry.Unknown1 = reader.ReadUInt32();
                entry.Unknown2 = reader.ReadUInt32();
                entry.Unknown3 = reader.ReadUInt32();
                entry.Unknown4 = reader.ReadUInt32();

                result.Unknown3.Add(entry);
            }

            int readSize = node.Size - ((int)reader.BaseStream.Position - node.Offset);
            result.TrailingBytes = reader.ReadBytes(readSize);

            result.Node = node;

            return result;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (JournalManager)node.Value;

            writer.Write(data.Entries.Count);
            foreach (var entry in data.Entries)
            {
                writer.Write(entry.Unk1_PathHash);
                writer.Write(entry.Unk2_State);
                writer.Write(entry.Unknown3);
                writer.Write(entry.Unknown4);
            }
            writer.Write(data.Unk1_TrackedQuestPath);

            writer.Write(data.Unknown2.Count);
            foreach (var entry in data.Unknown2)
            {
                writer.Write(entry);
            }

            writer.Write(data.Unknown3.Count);
            foreach (var entry in data.Unknown3)
            {
                writer.Write(entry.Unknown1);
                writer.Write(entry.Unknown2);
                writer.Write(entry.Unknown3);
                writer.Write(entry.Unknown4);
            }

            writer.Write(data.TrailingBytes);
        }
    }
}