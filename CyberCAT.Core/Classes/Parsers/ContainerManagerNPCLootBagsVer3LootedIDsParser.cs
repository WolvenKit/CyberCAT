using System;
using System.Collections.Generic;
using System.IO;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class ContainerManagerNPCLootBagsVer3LootedIDsParser : INodeParser
    {
        public string ParsableNodeName { get; }

        public string DisplayName { get; }

        public Guid Guid { get; }

        public ContainerManagerNPCLootBagsVer3LootedIDsParser()
        {
            ParsableNodeName = Constants.NodeNames.CONTAINER_MANAGER_NPC_LOOT_BAGS_VER3_LOOTED_IDS;
            DisplayName = "Containe rManager NPC Loot Bags Ver3 Looted IDs Parser";
            Guid = Guid.Parse("{4F842300-F184-4F50-986A-47D1CCE074D3}");
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new ContainerManagerNPCLootBagsVer3LootedIDs();

            reader.Skip(4); // Skip Id
            var entryCount = reader.ReadPackedInt();
            for (int i = 0; i < entryCount; i++)
            {
                result.EntityIds.Add(reader.ReadUInt64());
            }

            int readSize = node.Size - ((int)reader.BaseStream.Position - node.Offset);

            result.Node = node;

            return result;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (ContainerManagerNPCLootBagsVer3LootedIDs)node.Value;

            writer.WritePackedInt(data.EntityIds.Count);
            foreach (var entityId in data.EntityIds)
            {
                writer.Write(entityId);
            }
        }
    }
}