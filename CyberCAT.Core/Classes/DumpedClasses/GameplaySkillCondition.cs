using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("GameplaySkillCondition")]
    public class GameplaySkillCondition : GameplayConditionBase
    {
        [RealName("skillToCheck")]
        public TweakDbId SkillToCheck { get; set; }
        
        [RealName("difficulty")]
        public DumpedEnums.EGameplayChallengeLevel? Difficulty { get; set; }
    }
}
