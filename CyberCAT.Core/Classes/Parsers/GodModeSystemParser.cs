using CyberCAT.Core.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes.Parsers
{
    class GodModeSystemParser : GenericUnknownStructParser, INodeParser
    {
        public string ParsableNodeName { get; private set; }
        public string DisplayName { get; private set; }
        public Guid Guid { get; private set; }
        public GodModeSystemParser()
        {
            ParsableNodeName = Constants.NodeNames.GOD_MODE_SYSTEM;
            DisplayName = "Godmode System Parser";
            Guid = Guid.Parse("{F3108C87-6AE2-43E6-95FF-22611EDF25DF}");
        }
    }
}
