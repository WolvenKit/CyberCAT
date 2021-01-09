using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("BaseScriptableAction")]
    public class BaseScriptableAction : GamedeviceAction
    {
        [RealName("requesterID")]
        public EntEntityID RequesterID { get; set; }
        
        [RealName("objectActionID")]
        [RealType("TweakDBID")]
        public TweakDbId ObjectActionID { get; set; }
        
        [RealName("inkWidgetID")]
        [RealType("TweakDBID")]
        public TweakDbId InkWidgetID { get; set; }
        
        [RealName("interactionChoice")]
        public GameinteractionsChoice InteractionChoice { get; set; }
        
        [RealName("interactionLayer")]
        [RealType("CName")]
        public string InteractionLayer { get; set; }
        
        [RealName("isActionRPGCheckDissabled")]
        [RealType("Bool")]
        public bool IsActionRPGCheckDissabled { get; set; }
    }
}
