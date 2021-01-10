using System;
using System.Collections.Generic;
using System.IO;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class WorkspotInstancesSavedataParser : INodeParser
    {
        public string ParsableNodeName { get; }

        public string DisplayName { get; }

        public Guid Guid { get; }

        public WorkspotInstancesSavedataParser()
        {
            ParsableNodeName = Constants.NodeNames.WORKSPOT_INSTANCES_SAVEDATA;
            DisplayName = "Workspot Instances Savedata";
            Guid = Guid.Parse("{32DEE625-83AE-443B-9DD5-780F336054AF}");
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new WorkspotInstancesSavedata();

            reader.Skip(4); // Skip Id
            var entryCount = reader.ReadUInt32();
            for (int i = 0; i < entryCount; i++)
            {
                var entry = new WorkspotInstancesSavedata.WorkspotInstancesSavedataEntry();
                entry.Unk_Hash1 = reader.ReadUInt64();
                entry.Unk_EntityHash = reader.ReadUInt64();
                entry.Unknown3 = reader.ReadByte();

                result.WorkspotInstancesSavedataEntries.Add(entry);
            }

            return result;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (WorkspotInstancesSavedata)node.Value;

            writer.Write(data.WorkspotInstancesSavedataEntries.Count);
            foreach (var entry in data.WorkspotInstancesSavedataEntries)
            {
                writer.Write(entry.Unk_Hash1);
                writer.Write(entry.Unk_EntityHash);
                writer.Write(entry.Unknown3);
            }
        }
    }
}