
using CyberCAT.Core.Classes.Mapping.Global;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("BaseScriptableAction")]
    public class BaseScriptableAction : GamedeviceAction
    {
        [RealName("requesterID")]
        public EntEntityID RequesterID { get; set; }
        
        [RealName("objectActionID")]
        [RealType("TweakDBID")]
        public ulong ObjectActionID { get; set; }
        
        [RealName("inkWidgetID")]
        [RealType("TweakDBID")]
        public ulong InkWidgetID { get; set; }
        
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
