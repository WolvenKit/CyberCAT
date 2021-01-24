using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DistractionSetup")]
    public class DistractionSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("StimuliRange")]
        public float StimuliRange { get; set; }
        
        [RealName("disableOnActivation")]
        public bool DisableOnActivation { get; set; }
        
        [RealName("hasSimpleInteraction")]
        public bool HasSimpleInteraction { get; set; }
        
        [RealName("hasSpiderbotInteraction")]
        public bool HasSpiderbotInteraction { get; set; }
        
        [RealName("hasQuickHack")]
        public bool HasQuickHack { get; set; }
        
        [RealName("hasComputerInteraction")]
        public bool HasComputerInteraction { get; set; }
        
        [RealName("alternativeInteractionName")]
        public TweakDbId AlternativeInteractionName { get; set; }
        
        [RealName("alternativeSpiderbotInteractionName")]
        public TweakDbId AlternativeSpiderbotInteractionName { get; set; }
        
        [RealName("alternativeQuickHackName")]
        public TweakDbId AlternativeQuickHackName { get; set; }
        
        [RealName("skillChecks")]
        public Handle<EngDemoContainer> SkillChecks { get; set; }
        
        [RealName("explosionDefinition")]
        public ExplosiveDeviceResourceDefinition[] ExplosionDefinition { get; set; }
    }
}
