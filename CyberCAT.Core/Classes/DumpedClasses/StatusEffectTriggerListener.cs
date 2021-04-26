using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("StatusEffectTriggerListener")]
    public class StatusEffectTriggerListener : GameCustomValueStatPoolsListener
    {
        [RealName("owner")]
        public GameObject Owner { get; set; }
        
        [RealName("statusEffect")]
        public TweakDbId StatusEffect { get; set; }
        
        [RealName("statPoolType")]
        public DumpedEnums.gamedataStatPoolType? StatPoolType { get; set; }
        
        [RealName("instigator")]
        public GameObject Instigator { get; set; }
    }
}
