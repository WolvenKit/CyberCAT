using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class TimeSystemCoreParser : INodeParser
    {
        public string ParsableNodeName { get; }

        public string DisplayName { get; }

        public Guid Guid { get; }

        public TimeSystemCoreParser()
        {
            ParsableNodeName = Constants.NodeNames.TIME_CORE;
            DisplayName = "Time System Core Parser";
            Guid = Guid.Parse("{8D0EDD2B-770E-487A-BAD6-0EBC8A588282}");
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new TimeSystemCore();

            reader.Skip(4); // Skip Id

            result.Unknown1 = reader.ReadUInt32();
            result.CurrentGameTime = reader.ReadUInt32();
            result.Unknown2 = reader.ReadBytes(12);

            result.Node = node;

            return result;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (TimeSystemCore)node.Value;

            writer.Write(data.Unknown1);
            writer.Write(data.CurrentGameTime);
            writer.Write(data.Unknown2);
        }
    }
}