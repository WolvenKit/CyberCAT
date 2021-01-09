using CyberCAT.Core.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace CyberCAT.Core.Classes.Parsers
{
    public class ScriptableSystemsContainerParser : GenericUnknownStructParser, INodeParser
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

        public new object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            //var dict = MappingHelper.GetMappings("CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer");
            //var result = base.ReadWithMapping(node, reader, parsers, dict);
            var result = base.ReadWithMapping(node, reader, parsers);

            return result;
        }
    }
}
