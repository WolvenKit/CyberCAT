using System;
using System.Collections.Generic;
using System.IO;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class ContainerManagerParser : INodeParser
    {
        public string ParsableNodeName { get; }

        public string DisplayName { get; }

        public Guid Guid { get; }

        public ContainerManagerParser()
        {
            ParsableNodeName = Constants.NodeNames.CONTAINER_MANAGER;
            DisplayName = "Container Manager Parser";
            Guid = Guid.Parse("{57857253-87D6-43E1-A80B-75C2A18E0717}");
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new ContainerManager();

            reader.Skip(4); // Skip Id
            var entryCount = reader.ReadUInt32();
            for (int i = 0; i < entryCount; i++)
            {
                var entry = new ContainerManager.Entry();

                entry.CNameHash = reader.ReadUInt64();
                entry.Unknown1 = reader.ReadUInt16();

                result.Entries.Add(entry);
            }

            int readSize = node.Size - ((int)reader.BaseStream.Position - node.Offset);

            result.Node = node;

            return result;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (ContainerManager)node.Value;

            writer.Write(data.Entries.Count);
            foreach (var entry in data.Entries)
            {
                writer.Write(entry.CNameHash);
                writer.Write(entry.Unknown1);
            }
        }
    }
}