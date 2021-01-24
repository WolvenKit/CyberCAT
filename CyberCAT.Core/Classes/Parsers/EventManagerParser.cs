using System;
using System.Collections.Generic;
using System.IO;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class EventManagerParser : INodeParser
    {
        public string ParsableNodeName { get; }

        public string DisplayName { get; }

        public Guid Guid { get; }

        public EventManagerParser()
        {
            ParsableNodeName = Constants.NodeNames.EVENT_MANAGER;
            DisplayName = "Event Manager Parser";
            Guid = Guid.Parse("{0E5A421D-7370-48C0-933C-439CE7F802E9}");
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new EventManager();

            reader.Skip(4); // Skip Id
            var entryCount = reader.ReadUInt32();
            for (int i = 0; i < entryCount; i++)
            {
                var entry = new EventManager.Entry();

                entry.Unknown1 = reader.ReadUInt64();
                entry.Unknown2 = reader.ReadUInt32();
                entry.Unknown3 = reader.ReadUInt16();
                entry.Unknown4 = reader.ReadUInt16();

                result.Unknown.Add(entry);
            }

            int readSize = node.Size - ((int)reader.BaseStream.Position - node.Offset);

            result.Node = node;

            return result;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (EventManager)node.Value;

            writer.Write(data.Unknown.Count);
            foreach (var entry in data.Unknown)
            {
                writer.Write(entry.Unknown1);
                writer.Write(entry.Unknown2);
                writer.Write(entry.Unknown3);
                writer.Write(entry.Unknown4);
            }
        }
    }
}