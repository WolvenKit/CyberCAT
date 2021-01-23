using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ItemModificationSystem")]
    public class ItemModificationSystem : GameScriptableSystem
    {
        [RealName("blackboard")]
        public WHandle<GameIBlackboard> Blackboard { get; set; }
    }
}
