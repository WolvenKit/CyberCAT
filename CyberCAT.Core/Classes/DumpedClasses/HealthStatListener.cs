using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("HealthStatListener")]
    public class HealthStatListener : GameScriptStatPoolsListener
    {
        [RealName("ownerPuppet")]
        public PlayerPuppet OwnerPuppet { get; set; }
        
        [RealName("healthEvent")]
        public Handle<HealthUpdateEvent> HealthEvent { get; set; }
    }
}
