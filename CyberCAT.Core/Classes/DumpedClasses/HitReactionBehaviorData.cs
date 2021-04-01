using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("HitReactionBehaviorData")]
    public class HitReactionBehaviorData : IScriptable
    {
        [RealName("hitReactionType")]
        public DumpedEnums.animHitReactionType? HitReactionType { get; set; }
        
        [RealName("hitReactionActivationTimeStamp")]
        public float HitReactionActivationTimeStamp { get; set; }
        
        [RealName("hitReactionDuration")]
        public float HitReactionDuration { get; set; }
    }
}
