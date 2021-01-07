using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DistractionSetup")]
    public class DistractionSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("StimuliRange")]
        [RealType("Float")]
        public float StimuliRange { get; set; }
        
        [RealName("disableOnActivation")]
        [RealType("Bool")]
        public bool DisableOnActivation { get; set; }
        
        [RealName("hasSimpleInteraction")]
        [RealType("Bool")]
        public bool HasSimpleInteraction { get; set; }
        
        [RealName("hasSpiderbotInteraction")]
        [RealType("Bool")]
        public bool HasSpiderbotInteraction { get; set; }
        
        [RealName("hasQuickHack")]
        [RealType("Bool")]
        public bool HasQuickHack { get; set; }
        
        [RealName("hasComputerInteraction")]
        [RealType("Bool")]
        public bool HasComputerInteraction { get; set; }
        
        [RealName("alternativeInteractionName")]
        [RealType("TweakDBID")]
        public TweakDbId AlternativeInteractionName { get; set; }
        
        [RealName("alternativeSpiderbotInteractionName")]
        [RealType("TweakDBID")]
        public TweakDbId AlternativeSpiderbotInteractionName { get; set; }
        
        [RealName("alternativeQuickHackName")]
        [RealType("TweakDBID")]
        public TweakDbId AlternativeQuickHackName { get; set; }
        
        [RealName("skillChecks")]
        public Handle<EngDemoContainer> SkillChecks { get; set; }
        
        [RealName("explosionDefinition")]
        public ExplosiveDeviceResourceDefinition[] ExplosionDefinition { get; set; }
    }
}
