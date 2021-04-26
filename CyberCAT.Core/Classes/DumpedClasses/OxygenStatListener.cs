using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("OxygenStatListener")]
    public class OxygenStatListener : GameCustomValueStatPoolsListener
    {
        [RealName("ownerPuppet")]
        public PlayerPuppet OwnerPuppet { get; set; }
        
        [RealName("oxygenVfxBlackboard")]
        public Handle<WorldEffectBlackboard> OxygenVfxBlackboard { get; set; }
    }
}
