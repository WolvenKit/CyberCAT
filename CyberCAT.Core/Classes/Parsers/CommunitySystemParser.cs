using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class CommunitySystemParser : INodeParser
    {
        public string ParsableNodeName { get; }

        public string DisplayName { get; }

        public Guid Guid { get; }

        public CommunitySystemParser()
        {
            ParsableNodeName = Constants.NodeNames.COMMUNITY_SYSTEM;
            DisplayName = "Community System Parser";
            Guid = Guid.Parse("{03503150-83D2-46E0-B8FD-F5C3DAA031E1}");
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new CommunitySystem();

            reader.Skip(4); // Skip Id
            var entryCount = reader.ReadUInt32();
            for (int i = 0; i < entryCount; i++)
            {
                result.Unk_HashList.Add(reader.ReadUInt64());
            }

            int readSize = node.Size - ((int)reader.BaseStream.Position - node.Offset);
            Debug.Assert(readSize > 0);
            result.TrailingBytes = reader.ReadBytes(readSize);

            result.Node = node;

            return result;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (CommunitySystem)node.Value;

            writer.Write(data.Unk_HashList.Count);
            foreach (var entry in data.Unk_HashList)
            {
                writer.Write(entry);
            }
            writer.Write(data.TrailingBytes);
        }
    }
}