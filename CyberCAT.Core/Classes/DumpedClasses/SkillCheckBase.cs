using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SkillCheckBase")]
    public class SkillCheckBase : IScriptable
    {
        [RealName("alternativeName")]
        public TweakDbId AlternativeName { get; set; }
        
        [RealName("difficulty")]
        public DumpedEnums.EGameplayChallengeLevel? Difficulty { get; set; }
        
        [RealName("additionalRequirements")]
        public Handle<GameplayConditionContainer> AdditionalRequirements { get; set; }
        
        [RealName("duration")]
        public float Duration { get; set; }
        
        [RealName("isActive")]
        public bool IsActive { get; set; }
        
        [RealName("wasPassed")]
        public bool WasPassed { get; set; }
        
        [RealName("skillCheckPerformed")]
        public bool SkillCheckPerformed { get; set; }
        
        [RealName("skillToCheck")]
        public DumpedEnums.EDeviceChallengeSkill? SkillToCheck { get; set; }
        
        [RealName("baseSkill")]
        public Handle<GameplaySkillCondition> BaseSkill { get; set; }
        
        [RealName("isDynamic")]
        public bool IsDynamic { get; set; }
    }
}
