using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameinteractionsCHotSpotLayerDefinition")]
    public class GameinteractionsCHotSpotLayerDefinition : GameinteractionsNodeDefinition
    {
        [RealName("tag")]
        public CName Tag { get; set; }
        
        [RealName("enabled")]
        public bool Enabled { get; set; }
        
        [RealName("group")]
        public DumpedEnums.gameinteractionsEGroupType? Group { get; set; }
        
        [RealName("priorityMultiplier")]
        public float PriorityMultiplier { get; set; }
        
        [RealName("areaFilterDefinition")]
        public Handle<GameinteractionsCHotSpotAreaFilterDefinition> AreaFilterDefinition { get; set; }
        
        [RealName("gameLogicFilterDefinition")]
        public Handle<GameinteractionsCHotSpotGameLogicFilterDefinition> GameLogicFilterDefinition { get; set; }
    }
}
