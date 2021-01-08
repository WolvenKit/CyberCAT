using CyberCAT.Core.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace CyberCAT.Core.Classes.Parsers
{
    public class TierSystemParser : GenericUnknownStructParser, INodeParser
    {
        public string ParsableNodeName { get; private set; }
        public string DisplayName { get; private set; }
        public Guid Guid { get; private set; }

        public TierSystemParser()
        {
            ParsableNodeName = Constants.NodeNames.TIER_SYSTEM;
            DisplayName = "Tier System Parser";
            Guid = Guid.Parse("{A395977F-3EE9-4F00-A7D2-1123AC6C5B77}");
        }

        public new object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = base.ReadWithMapping(node, reader, parsers);

            return result;
        }
    }
}
