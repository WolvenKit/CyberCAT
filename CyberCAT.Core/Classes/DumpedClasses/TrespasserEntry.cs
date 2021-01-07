using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("TrespasserEntry")]
    public class TrespasserEntry : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("isScanned")]
        [RealType("Bool")]
        public bool IsScanned { get; set; }
        
        [RealName("isInsideA")]
        [RealType("Bool")]
        public bool IsInsideA { get; set; }
        
        [RealName("isInsideB")]
        [RealType("Bool")]
        public bool IsInsideB { get; set; }
        
        [RealName("isInsideScanner")]
        [RealType("Bool")]
        public bool IsInsideScanner { get; set; }
        
        [RealName("areaStack")]
        [RealType("CName")]
        public string[] AreaStack { get; set; }
    }
}
