using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SkillCheckBase")]
    public class SkillCheckBase : IScriptable
    {
        [RealName("alternativeName")]
        [RealType("TweakDBID")]
        public TweakDbId AlternativeName { get; set; }
        
        [RealName("difficulty")]
        public DumpedEnums.EGameplayChallengeLevel? Difficulty { get; set; }
        
        [RealName("additionalRequirements")]
        public Handle<GameplayConditionContainer> AdditionalRequirements { get; set; }
        
        [RealName("duration")]
        [RealType("Float")]
        public float Duration { get; set; }
        
        [RealName("isActive")]
        [RealType("Bool")]
        public bool IsActive { get; set; }
        
        [RealName("wasPassed")]
        [RealType("Bool")]
        public bool WasPassed { get; set; }
        
        [RealName("skillCheckPerformed")]
        [RealType("Bool")]
        public bool SkillCheckPerformed { get; set; }
        
        [RealName("skillToCheck")]
        public DumpedEnums.EDeviceChallengeSkill? SkillToCheck { get; set; }
        
        [RealName("baseSkill")]
        public Handle<GameplaySkillCondition> BaseSkill { get; set; }
        
        [RealName("isDynamic")]
        [RealType("Bool")]
        public bool IsDynamic { get; set; }
    }
}
