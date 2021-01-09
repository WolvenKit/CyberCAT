using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("PlayEffectDeviceOperation")]
    public class PlayEffectDeviceOperation : DeviceOperationBase
    {
        [RealName("VFXs")]
        public SVFXOperationData[] VFXs { get; set; }
        
        [RealName("fxInstances")]
        public SVfxInstanceData[] FxInstances { get; set; }
    }
}
