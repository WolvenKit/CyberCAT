using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ActivatorControllerPS")]
    public class ActivatorControllerPS : MasterControllerPS
    {
        [RealName("hasSpiderbotInteraction")]
        [RealType("Bool")]
        public bool HasSpiderbotInteraction { get; set; }
        
        [RealName("spiderbotInteractionLocationOverride")]
        [RealType("NodeRef")]
        public string SpiderbotInteractionLocationOverride { get; set; }
        
        [RealName("hasSimpleInteraction")]
        [RealType("Bool")]
        public bool HasSimpleInteraction { get; set; }
        
        [RealName("alternativeInteractionName")]
        [RealType("TweakDBID")]
        public TweakDbId AlternativeInteractionName { get; set; }
        
        [RealName("alternativeSpiderbotInteractionName")]
        [RealType("TweakDBID")]
        public TweakDbId AlternativeSpiderbotInteractionName { get; set; }
        
        [RealName("alternativeQuickHackName")]
        [RealType("TweakDBID")]
        public TweakDbId AlternativeQuickHackName { get; set; }
        
        [RealName("activatorSkillChecks")]
        public Handle<GenericContainer> ActivatorSkillChecks { get; set; }
        
        [RealName("alternativeInteractionString")]
        [RealType("String")]
        public string AlternativeInteractionString { get; set; }
    }
}
