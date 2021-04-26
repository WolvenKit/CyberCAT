using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameinteractionsInteractionDefinitionOverrider")]
    public class GameinteractionsInteractionDefinitionOverrider : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("tag")]
        public CName Tag { get; set; }
        
        [RealName("shapes")]
        public Handle<GameinteractionsIShapeDefinition>[] Shapes { get; set; }
        
        [RealName("negativeShapes")]
        public Handle<GameinteractionsIShapeDefinition>[] NegativeShapes { get; set; }
        
        [RealName("priorityMultiplier")]
        public float PriorityMultiplier { get; set; }
    }
}
