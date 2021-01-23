using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("STeleportOperationData")]
    public class STeleportOperationData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("nodeRef")]
        public NodeRef NodeRef { get; set; }
    }
}
