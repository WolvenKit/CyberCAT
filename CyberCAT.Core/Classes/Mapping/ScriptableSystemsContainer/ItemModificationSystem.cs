using CyberCAT.Core.Classes.Mapping.Global;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("ItemModificationSystem")]
    public class ItemModificationSystem : GameScriptableSystem
    {
        [RealName("blackboard")]
        public Handle<GameIBlackboard> Blackboard { get; set; }
    }
}
