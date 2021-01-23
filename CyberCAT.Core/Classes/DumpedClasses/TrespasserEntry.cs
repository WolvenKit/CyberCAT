using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("TrespasserEntry")]
    public class TrespasserEntry : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("isScanned")]
        public bool IsScanned { get; set; }
        
        [RealName("isInsideA")]
        public bool IsInsideA { get; set; }
        
        [RealName("isInsideB")]
        public bool IsInsideB { get; set; }
        
        [RealName("isInsideScanner")]
        public bool IsInsideScanner { get; set; }
        
        [RealName("areaStack")]
        public CName[] AreaStack { get; set; }
    }
}
