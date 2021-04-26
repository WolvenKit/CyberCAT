using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameinteractionsCHotSpotDefinition")]
    public class GameinteractionsCHotSpotDefinition : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("layersDefinition")]
        public Handle<GameinteractionsCLinkedLayersDefinition>[] LayersDefinition { get; set; }
        
        [RealName("suppressor")]
        public bool Suppressor { get; set; }
    }
}
