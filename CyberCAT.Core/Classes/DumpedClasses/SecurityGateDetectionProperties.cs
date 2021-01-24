using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SecurityGateDetectionProperties")]
    public class SecurityGateDetectionProperties : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("performWeaponCheck")]
        public bool PerformWeaponCheck { get; set; }
        
        [RealName("performCyberwareCheck")]
        public bool PerformCyberwareCheck { get; set; }
        
        [RealName("scannerEntranceType")]
        public DumpedEnums.ESecurityGateEntranceType? ScannerEntranceType { get; set; }
        
        [RealName("performCheckOnPlayerOnly")]
        public bool PerformCheckOnPlayerOnly { get; set; }
    }
}
