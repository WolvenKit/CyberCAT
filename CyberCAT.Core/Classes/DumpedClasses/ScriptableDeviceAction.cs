using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ScriptableDeviceAction")]
    public class ScriptableDeviceAction : BaseScriptableAction
    {
        [RealName("prop")]
        public Handle<GamedeviceActionProperty> Prop { get; set; }
        
        [RealName("actionWidgetPackage")]
        public SActionWidgetPackage ActionWidgetPackage { get; set; }
        
        [RealName("spiderbotActionLocationOverride")]
        public NodeRef SpiderbotActionLocationOverride { get; set; }
        
        [RealName("duration")]
        public float Duration { get; set; }
        
        [RealName("canTriggerStim")]
        public bool CanTriggerStim { get; set; }
        
        [RealName("wasPerformedOnOwner")]
        public bool WasPerformedOnOwner { get; set; }
        
        [RealName("shouldActivateDevice")]
        public bool ShouldActivateDevice { get; set; }
        
        [RealName("isQuickHack")]
        public bool IsQuickHack { get; set; }
        
        [RealName("isSpiderbotAction")]
        public bool IsSpiderbotAction { get; set; }
        
        [RealName("attachedProgram")]
        public TweakDbId AttachedProgram { get; set; }
        
        [RealName("activeStatusEffect")]
        public TweakDbId ActiveStatusEffect { get; set; }
        
        [RealName("interactionIconType")]
        public TweakDbId InteractionIconType { get; set; }
        
        [RealName("hasInteraction")]
        public bool HasInteraction { get; set; }
        
        [RealName("inactiveReason")]
        public string InactiveReason { get; set; }
    }
}
