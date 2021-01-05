using CyberCAT.Core.Classes.Mapping.Global;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("gameDeviceComponentPS")]
    public class GameDeviceComponentPS : GameComponentPS
    {
        [RealName("markAsQuest")]
        [RealType("Bool")]
        public bool MarkAsQuest { get; set; }
        
        [RealName("autoToggleQuestMark")]
        [RealType("Bool")]
        public bool AutoToggleQuestMark { get; set; }
        
        [RealName("factToDisableQuestMark")]
        [RealType("CName")]
        public string FactToDisableQuestMark { get; set; }
        
        [RealName("callbackToDisableQuestMarkID")]
        [RealType("Uint32")]
        public uint CallbackToDisableQuestMarkID { get; set; }
        
        [RealName("backdoorObjectiveData")]
        public Handle<BackDoorObjectiveData> BackdoorObjectiveData { get; set; }
        
        [RealName("controlPanelObjectiveData")]
        public Handle<ControlPanelObjectiveData> ControlPanelObjectiveData { get; set; }
        
        [RealName("isScanned")]
        [RealType("Bool")]
        public bool IsScanned { get; set; }
        
        [RealName("isBeingScanned")]
        [RealType("Bool")]
        public bool IsBeingScanned { get; set; }
        
        [RealName("exposeQuickHacks")]
        [RealType("Bool")]
        public bool ExposeQuickHacks { get; set; }
        
        [RealName("isAttachedToGame")]
        [RealType("Bool")]
        public bool IsAttachedToGame { get; set; }
        
        [RealName("isLogicReady")]
        [RealType("Bool")]
        public bool IsLogicReady { get; set; }
    }
}
