using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SDeviceActionData")]
    public class SDeviceActionData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("hasInteraction")]
        public bool HasInteraction { get; set; }
        
        [RealName("hasUI")]
        public bool HasUI { get; set; }
        
        [RealName("isQuickHack")]
        public bool IsQuickHack { get; set; }
        
        [RealName("isSpiderbotAction")]
        public bool IsSpiderbotAction { get; set; }
        
        [RealName("spiderbotLocationOverrideReference")]
        public NodeRef SpiderbotLocationOverrideReference { get; set; }
        
        [RealName("attachedToSkillCheck")]
        public DumpedEnums.EDeviceChallengeSkill? AttachedToSkillCheck { get; set; }
        
        [RealName("widgetRecord")]
        public TweakDbId WidgetRecord { get; set; }
        
        [RealName("objectActionRecord")]
        public TweakDbId ObjectActionRecord { get; set; }
        
        [RealName("currentDisplayName")]
        public CName CurrentDisplayName { get; set; }
        
        [RealName("interactionRecord")]
        public string InteractionRecord { get; set; }
    }
}
