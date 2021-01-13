using System;
using System.Collections.Generic;
using System.IO;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class PersistencySystemParser : INodeParser
    {
        public string ParsableNodeName { get; }

        public string DisplayName { get; }

        public Guid Guid { get; }

        public PersistencySystemParser()
        {
            ParsableNodeName = Constants.NodeNames.PERSISTENCY_SYSTEM;
            DisplayName = "Persistency System Parser";
            Guid = Guid.Parse("{C4117085-646B-437B-8488-F1A3261200E1}");
        }
        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new PersistencySystem();

            reader.Skip(4); // Skip Id
            var entryCount = reader.ReadUInt32();
            for (int i = 0; i < entryCount; i++)
            {
                result.Unk_HashList.Add(reader.ReadUInt32());
            }

            ParserUtils.ParseChildren(node.Children, reader, parsers);

            result.Node = node;

            return result;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (PersistencySystem)node.Value;

            writer.Write(data.Unk_HashList.Count);
            foreach (var id in data.Unk_HashList)
            {
                writer.Write(id);
            }

            foreach (var child in node.Children)
            {
                writer.Write(child);
            }
        }
    }
}