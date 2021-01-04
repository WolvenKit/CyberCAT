using System;
using System.Collections.Generic;
using System.IO;
using CyberCAT.Core.Classes.Interfaces;

namespace CyberCAT.Core.Classes.Parsers
{
    public class ScanningContollerParser : GenericUnknownStructParser, INodeParser
    {
        public string ParsableNodeName { get; private set; }
        public string DisplayName { get; private set; }
        public Guid Guid { get; private set; }

        public ScanningContollerParser()
        {
            ParsableNodeName = Constants.NodeNames.SCANNING_CONTROLLER;
            DisplayName = "Scanning Controller Parser";
            Guid = Guid.Parse("{086FCFD1-C533-4D68-B812-660B8C6BFB3F}");
        }

        public new object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = base.ReadWithMapping(node, reader, parsers);

            return result;
        }
    }
}