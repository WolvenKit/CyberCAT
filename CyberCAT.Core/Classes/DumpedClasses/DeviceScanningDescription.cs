using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DeviceScanningDescription")]
    public class DeviceScanningDescription : ObjectScanningDescription
    {
        [RealName("DeviceGameplayDescription")]
        [RealType("TweakDBID")]
        public TweakDbId DeviceGameplayDescription { get; set; }
        
        [RealName("DeviceCustomDescriptions")]
        [RealType("TweakDBID")]
        public TweakDbId[] DeviceCustomDescriptions { get; set; }
        
        [RealName("DeviceGameplayRole")]
        [RealType("TweakDBID")]
        public TweakDbId DeviceGameplayRole { get; set; }
        
        [RealName("DeviceRoleActionsDescriptions")]
        [RealType("TweakDBID")]
        public TweakDbId[] DeviceRoleActionsDescriptions { get; set; }
    }
}
