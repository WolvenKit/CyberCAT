using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameEffectExecutor")]
    public class GameEffectExecutor : GameEffectNode
    {
        [RealName("usesHitCooldown")]
        public bool UsesHitCooldown { get; set; }
    }
}
