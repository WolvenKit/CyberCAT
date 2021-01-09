using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SecurityLockerProperties")]
    public class SecurityLockerProperties : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("securityLevelAccessGranted")]
        public DumpedEnums.ESecurityAccessLevel? SecurityLevelAccessGranted { get; set; }
        
        [RealName("disableCyberware")]
        [RealType("Bool")]
        public bool DisableCyberware { get; set; }
        
        [RealName("storeWeaponSFX")]
        [RealType("CName")]
        public string StoreWeaponSFX { get; set; }
        
        [RealName("pickUpWeaponSFX")]
        [RealType("CName")]
        public string PickUpWeaponSFX { get; set; }
    }
}
