using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameinteractionsCHotSpotGameLogicFilterDefinition")]
    public class GameinteractionsCHotSpotGameLogicFilterDefinition : ISerializable
    {
        [RealName("hotSpotPrereq")]
        public Handle<GameIPrereq> HotSpotPrereq { get; set; }
        
        [RealName("activatorPrereq")]
        public Handle<GameIPrereq> ActivatorPrereq { get; set; }
        
        [RealName("scriptedConditionClass")]
        public Handle<GameinteractionsInteractionScriptedCondition> ScriptedConditionClass { get; set; }
    }
}
