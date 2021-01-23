using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ExplosiveTriggerDeviceControllerPS")]
    public class ExplosiveTriggerDeviceControllerPS : ExplosiveDeviceControllerPS
    {
        [RealName("playerSafePass")]
        public bool PlayerSafePass { get; set; }
        
        [RealName("triggerExploded")]
        public bool TriggerExploded { get; set; }
    }
}
