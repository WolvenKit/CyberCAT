using CyberCAT.Core.Classes.Mapping.Global;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("ScriptableDeviceAction")]
    public class ScriptableDeviceAction : BaseScriptableAction
    {
        [RealName("prop")]
        public Handle<GamedeviceActionProperty> Prop { get; set; }
        
        [RealName("actionWidgetPackage")]
        public SActionWidgetPackage ActionWidgetPackage { get; set; }
        
        [RealName("spiderbotActionLocationOverride")]
        [RealType("NodeRef")]
        public string SpiderbotActionLocationOverride { get; set; }
        
        [RealName("duration")]
        [RealType("Float")]
        public float Duration { get; set; }
        
        [RealName("canTriggerStim")]
        [RealType("Bool")]
        public bool CanTriggerStim { get; set; }
        
        [RealName("wasPerformedOnOwner")]
        [RealType("Bool")]
        public bool WasPerformedOnOwner { get; set; }
        
        [RealName("shouldActivateDevice")]
        [RealType("Bool")]
        public bool ShouldActivateDevice { get; set; }
        
        [RealName("isQuickHack")]
        [RealType("Bool")]
        public bool IsQuickHack { get; set; }
        
        [RealName("isSpiderbotAction")]
        [RealType("Bool")]
        public bool IsSpiderbotAction { get; set; }
        
        [RealName("attachedProgram")]
        [RealType("TweakDBID")]
        public TweakDbId AttachedProgram { get; set; }
        
        [RealName("activeStatusEffect")]
        [RealType("TweakDBID")]
        public TweakDbId ActiveStatusEffect { get; set; }
        
        [RealName("interactionIconType")]
        [RealType("TweakDBID")]
        public TweakDbId InteractionIconType { get; set; }
        
        [RealName("hasInteraction")]
        [RealType("Bool")]
        public bool HasInteraction { get; set; }
        
        [RealName("inactiveReason")]
        [RealType("String")]
        public string InactiveReason { get; set; }
    }
}
