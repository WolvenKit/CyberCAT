using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SecuritySystemData")]
    public class SecuritySystemData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("suppressIncomingEvents")]
        [RealType("Bool")]
        public bool SuppressIncomingEvents { get; set; }
        
        [RealName("suppressOutgoingEvents")]
        [RealType("Bool")]
        public bool SuppressOutgoingEvents { get; set; }
    }
}
