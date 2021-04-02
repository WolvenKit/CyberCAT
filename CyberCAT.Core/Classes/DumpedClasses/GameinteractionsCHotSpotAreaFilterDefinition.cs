using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameinteractionsCHotSpotAreaFilterDefinition")]
    public class GameinteractionsCHotSpotAreaFilterDefinition : GameinteractionsNodeDefinition
    {
        [RealName("slotName")]
        public CName SlotName { get; set; }
        
        [RealName("transform")]
        public Transform Transform { get; set; }
        
        [RealName("shapes")]
        public Handle<GameinteractionsIShapeDefinition>[] Shapes { get; set; }
        
        [RealName("negativeShapes")]
        public Handle<GameinteractionsIShapeDefinition>[] NegativeShapes { get; set; }
        
        [RealName("functor")]
        public Handle<GameinteractionsCFunctorDefinition> Functor { get; set; }
    }
}
