using System;
using System.Collections.Generic;
using System.IO;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class ContainerManagerNPCLootBagsVer2Parser : INodeParser
    {
        public string ParsableNodeName { get; }

        public string DisplayName { get; }

        public Guid Guid { get; }

        public ContainerManagerNPCLootBagsVer2Parser()
        {
            ParsableNodeName = Constants.NodeNames.CONTAINER_MANAGER_NPC_LOOT_BAGS_VER2;
            DisplayName = "Container Manager NPC Loot Bags Ver2 Parser";
            Guid = Guid.Parse("{FC4A1126-1234-461F-AE9E-60880948EE29}");
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new ContainerManagerNPCLootBagsVer2();

            reader.Skip(4); // Skip Id
            var entryCount = reader.ReadPackedInt();
            for (int i = 0; i < entryCount; i++)
            {
                var entry = new ContainerManagerNPCLootBagsVer2.Entry();
                entry.Unk_BaseClassName = reader.ReadPackedString();
                entry.Unknown2 = reader.ReadBytes(12);

                var subCount = reader.ReadByte();
                for (int j = 0; j < subCount; j++)
                {
                    var subEntry = new ContainerManagerNPCLootBagsVer2.Item();
                    subEntry.Unk1_ItemTbdId = reader.ReadTweakDbId();
                    subEntry.Unk1_Seed = reader.ReadUInt32();
                    subEntry.Unk2_Counter = reader.ReadUInt16();
                    subEntry.Unk2_ItemTbdId = reader.ReadTweakDbId();
                    subEntry.Unk2_Seed = reader.ReadUInt32();

                    entry.Items.Add(subEntry);
                }

                entry.EntityId = reader.ReadUInt64();

                result.Entries.Add(entry);
            }

            int readSize = node.Size - ((int)reader.BaseStream.Position - node.Offset);

            result.Node = node;

            return result;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (ContainerManagerNPCLootBagsVer2)node.Value;

            writer.WritePackedInt(data.Entries.Count);
            foreach (var entry in data.Entries)
            {
                writer.WritePackedString(entry.Unk_BaseClassName);
                writer.Write(entry.Unknown2);
                writer.Write((byte)entry.Items.Count);
                foreach (var item in entry.Items)
                {
                    writer.Write(item.Unk1_ItemTbdId);
                    writer.Write(item.Unk1_Seed);
                    writer.Write(item.Unk2_Counter);
                    writer.Write(item.Unk2_ItemTbdId);
                    writer.Write(item.Unk2_Seed);
                }
                writer.Write(entry.EntityId);
            }
        }
    }
}