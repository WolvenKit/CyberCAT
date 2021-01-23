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
        public bool DisableCyberware { get; set; }
        
        [RealName("storeWeaponSFX")]
        public CName StoreWeaponSFX { get; set; }
        
        [RealName("pickUpWeaponSFX")]
        public CName PickUpWeaponSFX { get; set; }
    }
}
