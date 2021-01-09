using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ActivatedDeviceSetup")]
    public class ActivatedDeviceSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("actionName")]
        [RealType("CName")]
        public string ActionName { get; set; }
        
        [RealName("disableOnActivation")]
        [RealType("Bool")]
        public bool DisableOnActivation { get; set; }
        
        [RealName("glitchOnActivation")]
        [RealType("Bool")]
        public bool GlitchOnActivation { get; set; }
        
        [RealName("vfxResource")]
        public GameFxResource VfxResource { get; set; }
        
        [RealName("activationVFXname")]
        [RealType("CName")]
        public string ActivationVFXname { get; set; }
        
        [RealName("hasSimpleInteraction")]
        [RealType("Bool")]
        public bool HasSimpleInteraction { get; set; }
        
        [RealName("hasSpiderbotInteraction")]
        [RealType("Bool")]
        public bool HasSpiderbotInteraction { get; set; }
        
        [RealName("hasQuickHack")]
        [RealType("Bool")]
        public bool HasQuickHack { get; set; }
        
        [RealName("hasQuickHackDistraction")]
        [RealType("Bool")]
        public bool HasQuickHackDistraction { get; set; }
        
        [RealName("alternativeInteractionName")]
        [RealType("TweakDBID")]
        public TweakDbId AlternativeInteractionName { get; set; }
        
        [RealName("alternativeSpiderbotInteractionName")]
        [RealType("TweakDBID")]
        public TweakDbId AlternativeSpiderbotInteractionName { get; set; }
        
        [RealName("alternativeQuickHackName")]
        [RealType("TweakDBID")]
        public TweakDbId AlternativeQuickHackName { get; set; }
        
        [RealName("activatedDeviceSkillChecks")]
        public Handle<EngDemoContainer> ActivatedDeviceSkillChecks { get; set; }
        
        [RealName("attackType")]
        [RealType("TweakDBID")]
        public TweakDbId AttackType { get; set; }
        
        [RealName("shouldActivateTrapOnAreaEnter")]
        [RealType("Bool")]
        public bool ShouldActivateTrapOnAreaEnter { get; set; }
        
        [RealName("deviceWidgetRecord")]
        [RealType("TweakDBID")]
        public TweakDbId DeviceWidgetRecord { get; set; }
        
        [RealName("thumbnailIconRecord")]
        [RealType("TweakDBID")]
        public TweakDbId ThumbnailIconRecord { get; set; }
        
        [RealName("actionWidgetRecord")]
        [RealType("TweakDBID")]
        public TweakDbId ActionWidgetRecord { get; set; }
    }
}
