using System;
using System.Collections.Generic;
using System.IO;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class ChoicesParser : INodeParser
    {
        public string ParsableNodeName { get; }

        public string DisplayName { get; }

        public Guid Guid { get; }

        public ChoicesParser()
        {
            ParsableNodeName = Constants.NodeNames.CHOICES;
            DisplayName = "Choices Parser";
            Guid = Guid.Parse("{B9B2C821-FC69-4E22-839D-E8351511462D}");
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new Choices();

            reader.Skip(4); // Skip Id
            var entryCount = reader.ReadUInt32();
            for (int i = 0; i < entryCount; i++)
            {
                var entry = new Choices.Entry1();

                entry.Unknown1 = reader.ReadUInt64();

                var subEntryCount = reader.ReadUInt32();
                for (int j = 0; j < subEntryCount; j++)
                {
                    var subEntry = new Choices.Entry2();

                    subEntry.Unknown1 = reader.ReadUInt32();
                    subEntry.Unknown2 = reader.ReadUInt32();
                    subEntry.Unknown3 = reader.ReadUInt32();

                    entry.Unknown2.Add(subEntry);
                }

                result.Unknown1.Add(entry);
            }

            int readSize = node.Size - ((int)reader.BaseStream.Position - node.Offset);

            result.Node = node;

            return result;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (Choices)node.Value;

            writer.Write(data.Unknown1.Count);
            foreach (var entry in data.Unknown1)
            {
                writer.Write(entry.Unknown1);

                writer.Write(entry.Unknown2.Count);
                foreach (var subEntry in entry.Unknown2)
                {
                    writer.Write(subEntry.Unknown1);
                    writer.Write(subEntry.Unknown2);
                    writer.Write(subEntry.Unknown3);
                }
            }
        }
    }
}