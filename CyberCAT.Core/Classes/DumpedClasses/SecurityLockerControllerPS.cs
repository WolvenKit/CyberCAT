using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SecurityLockerControllerPS")]
    public class SecurityLockerControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("securityLockerProperties")]
        public SecurityLockerProperties SecurityLockerProperties { get; set; }
        
        [RealName("isStoringPlayerEquipement")]
        [RealType("Bool")]
        public bool IsStoringPlayerEquipement { get; set; }
    }
}
