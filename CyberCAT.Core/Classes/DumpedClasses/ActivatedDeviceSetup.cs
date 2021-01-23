using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ActivatedDeviceSetup")]
    public class ActivatedDeviceSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("actionName")]
        public CName ActionName { get; set; }
        
        [RealName("disableOnActivation")]
        public bool DisableOnActivation { get; set; }
        
        [RealName("glitchOnActivation")]
        public bool GlitchOnActivation { get; set; }
        
        [RealName("vfxResource")]
        public GameFxResource VfxResource { get; set; }
        
        [RealName("activationVFXname")]
        public CName ActivationVFXname { get; set; }
        
        [RealName("hasSimpleInteraction")]
        public bool HasSimpleInteraction { get; set; }
        
        [RealName("hasSpiderbotInteraction")]
        public bool HasSpiderbotInteraction { get; set; }
        
        [RealName("hasQuickHack")]
        public bool HasQuickHack { get; set; }
        
        [RealName("hasQuickHackDistraction")]
        public bool HasQuickHackDistraction { get; set; }
        
        [RealName("alternativeInteractionName")]
        public TweakDbId AlternativeInteractionName { get; set; }
        
        [RealName("alternativeSpiderbotInteractionName")]
        public TweakDbId AlternativeSpiderbotInteractionName { get; set; }
        
        [RealName("alternativeQuickHackName")]
        public TweakDbId AlternativeQuickHackName { get; set; }
        
        [RealName("activatedDeviceSkillChecks")]
        public Handle<EngDemoContainer> ActivatedDeviceSkillChecks { get; set; }
        
        [RealName("attackType")]
        public TweakDbId AttackType { get; set; }
        
        [RealName("shouldActivateTrapOnAreaEnter")]
        public bool ShouldActivateTrapOnAreaEnter { get; set; }
        
        [RealName("deviceWidgetRecord")]
        public TweakDbId DeviceWidgetRecord { get; set; }
        
        [RealName("thumbnailIconRecord")]
        public TweakDbId ThumbnailIconRecord { get; set; }
        
        [RealName("actionWidgetRecord")]
        public TweakDbId ActionWidgetRecord { get; set; }
    }
}
