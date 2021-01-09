using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SActionTypeForward")]
    public class SActionTypeForward : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("qHack")]
        [RealType("Bool")]
        public bool QHack { get; set; }
        
        [RealName("techie")]
        [RealType("Bool")]
        public bool Techie { get; set; }
        
        [RealName("master")]
        [RealType("Bool")]
        public bool Master { get; set; }
    }
}
