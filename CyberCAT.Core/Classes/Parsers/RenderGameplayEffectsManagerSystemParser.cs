using CyberCAT.Core.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes.Parsers
{
    class RenderGameplayEffectsManagerSystemParser : GenericUnknownStructParser, INodeParser
    {
        public string ParsableNodeName { get; private set; }
        public string DisplayName { get; private set; }
        public Guid Guid { get; private set; }
        public RenderGameplayEffectsManagerSystemParser()
        {
            ParsableNodeName = Constants.NodeNames.RENDER_GAMEPLAY_EFFECTS_MANAGER_SYSTEM;
            DisplayName = "Render Gameplay Effects Manager System Parser";
            Guid = Guid.Parse("{FA0D8394-7FC9-4BBE-AA2C-5F6D467993E9}");
        }
    }
}
