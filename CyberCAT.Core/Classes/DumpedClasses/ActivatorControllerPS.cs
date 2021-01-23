using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ActivatorControllerPS")]
    public class ActivatorControllerPS : MasterControllerPS
    {
        [RealName("hasSpiderbotInteraction")]
        public bool HasSpiderbotInteraction { get; set; }
        
        [RealName("spiderbotInteractionLocationOverride")]
        public NodeRef SpiderbotInteractionLocationOverride { get; set; }
        
        [RealName("hasSimpleInteraction")]
        public bool HasSimpleInteraction { get; set; }
        
        [RealName("alternativeInteractionName")]
        public TweakDbId AlternativeInteractionName { get; set; }
        
        [RealName("alternativeSpiderbotInteractionName")]
        public TweakDbId AlternativeSpiderbotInteractionName { get; set; }
        
        [RealName("alternativeQuickHackName")]
        public TweakDbId AlternativeQuickHackName { get; set; }
        
        [RealName("activatorSkillChecks")]
        public Handle<GenericContainer> ActivatorSkillChecks { get; set; }
        
        [RealName("alternativeInteractionString")]
        public string AlternativeInteractionString { get; set; }
    }
}
