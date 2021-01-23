using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameDeviceComponentPS")]
    public class GameDeviceComponentPS : GameComponentPS
    {
        [RealName("markAsQuest")]
        public bool MarkAsQuest { get; set; }
        
        [RealName("autoToggleQuestMark")]
        public bool AutoToggleQuestMark { get; set; }
        
        [RealName("factToDisableQuestMark")]
        public CName FactToDisableQuestMark { get; set; }
        
        [RealName("callbackToDisableQuestMarkID")]
        public uint CallbackToDisableQuestMarkID { get; set; }
        
        [RealName("backdoorObjectiveData")]
        public Handle<BackDoorObjectiveData> BackdoorObjectiveData { get; set; }
        
        [RealName("controlPanelObjectiveData")]
        public Handle<ControlPanelObjectiveData> ControlPanelObjectiveData { get; set; }
        
        [RealName("isScanned")]
        public bool IsScanned { get; set; }
        
        [RealName("isBeingScanned")]
        public bool IsBeingScanned { get; set; }
        
        [RealName("exposeQuickHacks")]
        public bool ExposeQuickHacks { get; set; }
        
        [RealName("isAttachedToGame")]
        public bool IsAttachedToGame { get; set; }
        
        [RealName("isLogicReady")]
        public bool IsLogicReady { get; set; }
    }
}
