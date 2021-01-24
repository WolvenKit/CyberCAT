using System;
using System.Collections.Generic;
using System.IO;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class ContainerManagerLootSlotAvailabilityParser : INodeParser
    {
        public string ParsableNodeName { get; }

        public string DisplayName { get; }

        public Guid Guid { get; }

        public ContainerManagerLootSlotAvailabilityParser()
        {
            ParsableNodeName = Constants.NodeNames.CONTAINER_MANAGER_LOOT_SLOT_AVAILABILITY;
            DisplayName = "Container Manager Loot Slot Availability Parser";
            Guid = Guid.Parse("{C0CCB15E-68E0-4206-88AC-160AF6197C8B}");
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new ContainerManagerLootSlotAvailability();

            reader.Skip(4); // Skip Id
            var entryCount = reader.ReadPackedInt();
            for (int i = 0; i < entryCount; i++)
            {
                var entry = new ContainerManagerLootSlotAvailability.Entry();

                entry.CNameHash = reader.ReadUInt64();

                result.Entries.Add(entry);
            }

            foreach (var entry in result.Entries)
            {
                entry.Unknown1 = reader.ReadByte();
            }

            int readSize = node.Size - ((int)reader.BaseStream.Position - node.Offset);

            result.Node = node;

            return result;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (ContainerManagerLootSlotAvailability)node.Value;

            writer.WritePackedInt(data.Entries.Count);
            foreach (var entry in data.Entries)
            {
                writer.Write(entry.CNameHash);
            }

            foreach (var entry in data.Entries)
            {
                writer.Write(entry.Unknown1);
            }
        }
    }
}