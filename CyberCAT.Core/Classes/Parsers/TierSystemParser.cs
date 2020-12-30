using CyberCAT.Core.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes.Parsers
{
    class TierSystemParser : GenericUnknownStructParser, INodeParser
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
    }
}
