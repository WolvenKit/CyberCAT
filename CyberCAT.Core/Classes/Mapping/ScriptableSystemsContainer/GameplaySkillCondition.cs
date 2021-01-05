
namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("GameplaySkillCondition")]
    public class GameplaySkillCondition : GameplayConditionBase
    {
        [RealName("skillToCheck")]
        [RealType("TweakDBID")]
        public ulong SkillToCheck { get; set; }
        
        [RealName("difficulty")]
        public DumpedEnums.EGameplayChallengeLevel? Difficulty { get; set; }
    }
}
