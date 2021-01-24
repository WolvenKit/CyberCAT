using System;
using System.Collections.Generic;
using System.IO;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class ContainerManagerInjectedLootParser : INodeParser
    {
        public string ParsableNodeName { get; }

        public string DisplayName { get; }

        public Guid Guid { get; }

        public ContainerManagerInjectedLootParser()
        {
            ParsableNodeName = Constants.NodeNames.CONTAINER_MANAGER_INJECTED_LOOT;
            DisplayName = "Container Manager Injected Loot Parser";
            Guid = Guid.Parse("{D3322E55-A3C0-4632-AB77-985CEA5198C6}");
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new ContainerManagerInjectedLoot();

            reader.Skip(4); // Skip Id
            var entryCount = reader.ReadPackedInt();

            for (int i = 0; i < entryCount; i++)
            {
                result.Entries.Add(new ContainerManagerInjectedLoot.Entry{EntityId = reader.ReadUInt64()});
            }

            foreach (var entry in result.Entries)
            {
                entry.Entries = new List<ContainerManagerInjectedLoot.SubEntry>();

                var subEntryCount = reader.ReadByte();
                for (int i = 0; i < subEntryCount; i++)
                {
                    var subEntry = new ContainerManagerInjectedLoot.SubEntry();

                    subEntry.ItemTbdId = reader.ReadTweakDbId();
                    subEntry.Unknown2 = reader.ReadByte();
                    subEntry.Unknown3 = reader.ReadUInt32();
                    subEntry.Unknown4 = reader.ReadByte();

                    entry.Entries.Add(subEntry);
                }
            }

            int readSize = node.Size - ((int)reader.BaseStream.Position - node.Offset);

            result.Node = node;

            return result;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (ContainerManagerInjectedLoot)node.Value;

            writer.WritePackedInt(data.Entries.Count);
            foreach (var entry in data.Entries)
            {
                writer.Write(entry.EntityId);
            }

            foreach (var entry in data.Entries)
            {
                writer.Write((byte)entry.Entries.Count);
                foreach (var subEntry in entry.Entries)
                {
                    writer.Write(subEntry.ItemTbdId);
                    writer.Write(subEntry.Unknown2);
                    writer.Write(subEntry.Unknown3);
                    writer.Write(subEntry.Unknown4);
                }
            }
        }
    }
}