using System;
using System.Collections.Generic;
using System.IO;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class CAttitudeManagerParser : INodeParser
    {
        public string ParsableNodeName { get; }

        public string DisplayName { get; }

        public Guid Guid { get; }

        public CAttitudeManagerParser()
        {
            ParsableNodeName = Constants.NodeNames.C_ATTITUDE_MANAGER;
            DisplayName = "C Attitude Manager";
            Guid = Guid.Parse("{A2E2A62F-E0A8-4B8F-B7D2-EDF47FAACF14}");
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new CAttitudeManager();

            reader.Skip(4); // Skip Id
            var entryCount = reader.ReadUInt32();
            for (int i = 0; i < entryCount; i++)
            {
                var entry = new CAttitudeManager.CAttitudeManagerEntry();
                entry.Unk_Hash1 = reader.ReadUInt64();
                entry.Unknown2 = reader.ReadUInt32();

                result.CAttitudeManagerEntries.Add(entry);
            }
            result.Unknown2 = reader.ReadBytes(18);

            return result;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (CAttitudeManager)node.Value;

            writer.Write(data.CAttitudeManagerEntries.Count);
            foreach (var entry in data.CAttitudeManagerEntries)
            {
                writer.Write(entry.Unk_Hash1);
                writer.Write(entry.Unknown2);
            }
            writer.Write(data.Unknown2);
        }
    }
}