using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ExplosiveTriggerDeviceControllerPS")]
    public class ExplosiveTriggerDeviceControllerPS : ExplosiveDeviceControllerPS
    {
        [RealName("playerSafePass")]
        [RealType("Bool")]
        public bool PlayerSafePass { get; set; }
        
        [RealName("triggerExploded")]
        [RealType("Bool")]
        public bool TriggerExploded { get; set; }
    }
}
