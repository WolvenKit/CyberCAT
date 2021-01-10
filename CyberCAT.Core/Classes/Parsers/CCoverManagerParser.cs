using System;
using System.Collections.Generic;
using System.IO;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class CCoverManagerParser : INodeParser
    {
        public string ParsableNodeName { get; }

        public string DisplayName { get; }

        public Guid Guid { get; }

        public CCoverManagerParser()
        {
            ParsableNodeName = Constants.NodeNames.C_COVER_MANAGER;
            DisplayName = "C Cover Manager Parser";
            Guid = Guid.Parse("{C0B1C37B-546D-4C47-B941-60721B5738EB}");
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new CCoverManager();

            reader.Skip(4); // Skip Id
            var entryCount = reader.ReadUInt32();
            for (int i = 0; i < entryCount; i++)
            {
                var entry = new CCoverManager.CCoverManagerEntry();
                entry.Unk_Hash1 = reader.ReadUInt64();
                entry.Unk_EntityHash = reader.ReadUInt64();
                entry.Unknown3 = reader.ReadByte();

                result.CCoverManagerEntries.Add(entry);
            }

            return result;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (CCoverManager)node.Value;

            writer.Write(data.CCoverManagerEntries.Count);
            foreach (var entry in data.CCoverManagerEntries)
            {
                writer.Write(entry.Unk_Hash1);
                writer.Write(entry.Unk_EntityHash);
                writer.Write(entry.Unknown3);
            }
        }
    }
}