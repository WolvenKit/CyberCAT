using CyberCAT.Core.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes.Parsers
{
    class StatsSystemParser : GenericUnknownStructParser, INodeParser
    {
        public string ParsableNodeName { get; private set; }
        public string DisplayName { get; private set; }
        public Guid Guid { get; private set; }
        public StatsSystemParser()
        {
            ParsableNodeName = Constants.NodeNames.STATS_SYSTEM;
            DisplayName = "Stat System Parser";
            Guid = Guid.Parse("{8F3788DA-3ECD-47FC-A6F9-A50314F61AA7}");
        }
    }
}
