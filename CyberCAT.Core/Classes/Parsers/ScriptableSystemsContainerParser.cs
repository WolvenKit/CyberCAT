using CyberCAT.Core.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes.Parsers
{
    class ScriptableSystemsContainerParser : GenericUnknownStructParser, INodeParser
    {
        public string ParsableNodeName { get; private set; }
        public string DisplayName { get; private set; }
        public Guid Guid { get; private set; }
        public ScriptableSystemsContainerParser()
        {
            ParsableNodeName = Constants.NodeNames.SCRIPTABLE_SYSTEMS_CONTAINER;
            DisplayName = "Scriptable Systems Container Parser";
            Guid = Guid.Parse("{51B5B214-DC85-4B8B-B516-832F468C75F7}");
        }
    }
}
