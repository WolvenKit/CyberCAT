using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("BaseScriptableAction")]
    public class BaseScriptableAction : GamedeviceAction
    {
        [RealName("requesterID")]
        public EntEntityID RequesterID { get; set; }
        
        [RealName("objectActionID")]
        public TweakDbId ObjectActionID { get; set; }
        
        [RealName("inkWidgetID")]
        public TweakDbId InkWidgetID { get; set; }
        
        [RealName("interactionChoice")]
        public GameinteractionsChoice InteractionChoice { get; set; }
        
        [RealName("interactionLayer")]
        public CName InteractionLayer { get; set; }
        
        [RealName("isActionRPGCheckDissabled")]
        public bool IsActionRPGCheckDissabled { get; set; }
    }
}
