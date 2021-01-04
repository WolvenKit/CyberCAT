using CyberCAT.Core.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace CyberCAT.Core.Classes.Parsers
{
    class StatPoolSystemParser : GenericUnknownStructParser, INodeParser
    {
        public string ParsableNodeName { get; private set; }
        public string DisplayName { get; private set; }
        public Guid Guid { get; private set; }

        public StatPoolSystemParser()
        {
            ParsableNodeName = Constants.NodeNames.STAT_POOLS_SYSTEM;
            DisplayName = "Stat Pool System Parser";
            Guid = Guid.Parse("{DA3AE1A3-840E-4069-9F75-5E4E127E34A0}");
        }

        public new object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = base.ReadWithMapping(node, reader, parsers);

            return result;
        }
    }
}
