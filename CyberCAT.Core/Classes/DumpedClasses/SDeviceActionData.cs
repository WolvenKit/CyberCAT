using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SDeviceActionData")]
    public class SDeviceActionData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("hasInteraction")]
        [RealType("Bool")]
        public bool HasInteraction { get; set; }
        
        [RealName("hasUI")]
        [RealType("Bool")]
        public bool HasUI { get; set; }
        
        [RealName("isQuickHack")]
        [RealType("Bool")]
        public bool IsQuickHack { get; set; }
        
        [RealName("isSpiderbotAction")]
        [RealType("Bool")]
        public bool IsSpiderbotAction { get; set; }
        
        [RealName("spiderbotLocationOverrideReference")]
        [RealType("NodeRef")]
        public string SpiderbotLocationOverrideReference { get; set; }
        
        [RealName("attachedToSkillCheck")]
        public DumpedEnums.EDeviceChallengeSkill? AttachedToSkillCheck { get; set; }
        
        [RealName("widgetRecord")]
        [RealType("TweakDBID")]
        public TweakDbId WidgetRecord { get; set; }
        
        [RealName("objectActionRecord")]
        [RealType("TweakDBID")]
        public TweakDbId ObjectActionRecord { get; set; }
        
        [RealName("currentDisplayName")]
        [RealType("CName")]
        public string CurrentDisplayName { get; set; }
        
        [RealName("interactionRecord")]
        [RealType("String")]
        public string InteractionRecord { get; set; }
    }
}
