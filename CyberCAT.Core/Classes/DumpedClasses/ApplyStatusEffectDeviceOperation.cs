using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ApplyStatusEffectDeviceOperation")]
    public class ApplyStatusEffectDeviceOperation : DeviceOperationBase
    {
        [RealName("statusEffects")]
        public SStatusEffectOperationData[] StatusEffects { get; set; }
    }
}
