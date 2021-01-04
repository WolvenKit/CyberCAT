using CyberCAT.Core.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace CyberCAT.Core.Classes.Parsers
{
    class MovingPlatformSystemParser: GenericUnknownStructParser, INodeParser
    {
        public string ParsableNodeName { get; private set; }
        public string DisplayName { get; private set; }
        public Guid Guid { get; private set; }

        public MovingPlatformSystemParser()
        {
            ParsableNodeName = Constants.NodeNames.MOVING_PLATFORM_SYSTEM;
            DisplayName = "Moving Platform System Parser";
            Guid = Guid.Parse("{C2A76B66-A8AF-437D-BA7C-3ABF76172CCD}");
        }

        public new object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = base.ReadWithMapping(node, reader, parsers);

            return result;
        }
    }
}
