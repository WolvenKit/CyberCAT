using System;
using System.Collections.Generic;
using System.IO;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class DSDynamicConnectionsParser : INodeParser
    {
        public string ParsableNodeName { get; }

        public string DisplayName { get; }

        public Guid Guid { get; }

        public DSDynamicConnectionsParser()
        {
            ParsableNodeName = Constants.NodeNames.DS_DYNAMIC_CONNECTIONS;
            DisplayName = "DS Dynamic Connections Parser";
            Guid = Guid.Parse("{E0FD5193-08AE-4CAA-8D45-F6CED218401C}");
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new DSDynamicConnections();

            reader.Skip(4); // Skip Id
            var entryCount = reader.ReadPackedInt();
            for (int i = 0; i < entryCount; i++)
            {
                var entry = new DSDynamicConnections.Entry();

                entry.Unknown1 = reader.ReadUInt64();

                result.Entries.Add(entry);
            }

            foreach (var entry in result.Entries)
            {
                entry.Unknown2 = reader.ReadPackedString();

                var subCount = reader.ReadPackedInt();
                for (int i = 0; i < subCount; i++)
                {
                    entry.Unknown3.Add(reader.ReadUInt64());
                }

                subCount = reader.ReadPackedInt();
                for (int i = 0; i < subCount; i++)
                {
                    entry.Unknown4.Add(reader.ReadUInt64());
                }

                entry.Unknown5 = reader.ReadBytes(12);
                entry.Unknown6 = reader.ReadPackedString();
            }

            int readSize = node.Size - ((int)reader.BaseStream.Position - node.Offset);

            result.Node = node;

            return result;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (DSDynamicConnections)node.Value;

            writer.WritePackedInt(data.Entries.Count);
            foreach (var entry in data.Entries)
            {
                writer.Write(entry.Unknown1);
            }

            foreach (var entry in data.Entries)
            {
                writer.WritePackedString(entry.Unknown2);

                writer.WritePackedInt(entry.Unknown3.Count);
                foreach (var val in entry.Unknown3)
                {
                    writer.Write(val);
                }

                writer.WritePackedInt(entry.Unknown4.Count);
                foreach (var val in entry.Unknown4)
                {
                    writer.Write(val);
                }

                writer.Write(entry.Unknown5);
                writer.WritePackedString(entry.Unknown6);
            }
        }
    }
}