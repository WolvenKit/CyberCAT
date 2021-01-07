using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SecurityGateDetectionProperties")]
    public class SecurityGateDetectionProperties : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("performWeaponCheck")]
        [RealType("Bool")]
        public bool PerformWeaponCheck { get; set; }
        
        [RealName("performCyberwareCheck")]
        [RealType("Bool")]
        public bool PerformCyberwareCheck { get; set; }
        
        [RealName("scannerEntranceType")]
        public DumpedEnums.ESecurityGateEntranceType? ScannerEntranceType { get; set; }
        
        [RealName("performCheckOnPlayerOnly")]
        [RealType("Bool")]
        public bool PerformCheckOnPlayerOnly { get; set; }
    }
}
