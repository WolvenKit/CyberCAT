using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SActionTypeForward")]
    public class SActionTypeForward : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("qHack")]
        public bool QHack { get; set; }
        
        [RealName("techie")]
        public bool Techie { get; set; }
        
        [RealName("master")]
        public bool Master { get; set; }
    }
}
