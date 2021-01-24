using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DeviceScanningDescription")]
    public class DeviceScanningDescription : ObjectScanningDescription
    {
        [RealName("DeviceGameplayDescription")]
        public TweakDbId DeviceGameplayDescription { get; set; }
        
        [RealName("DeviceCustomDescriptions")]
        public TweakDbId[] DeviceCustomDescriptions { get; set; }
        
        [RealName("DeviceGameplayRole")]
        public TweakDbId DeviceGameplayRole { get; set; }
        
        [RealName("DeviceRoleActionsDescriptions")]
        public TweakDbId[] DeviceRoleActionsDescriptions { get; set; }
    }
}
