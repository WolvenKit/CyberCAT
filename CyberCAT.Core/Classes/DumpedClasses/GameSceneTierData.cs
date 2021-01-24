using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameSceneTierData")]
    public class GameSceneTierData : IScriptable
    {
        [RealName("tier")]
        public DumpedEnums.GameplayTier? Tier { get; set; }
        
        [RealName("emptyHands")]
        public bool EmptyHands { get; set; }
    }
}
