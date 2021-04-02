using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameinteractionsCLinkedLayersDefinition")]
    public class GameinteractionsCLinkedLayersDefinition : GameinteractionsNodeDefinition
    {
        [RealName("tag")]
        public CName Tag { get; set; }
        
        [RealName("layersDefinitions")]
        public Handle<GameinteractionsCHotSpotLayerDefinition>[] LayersDefinitions { get; set; }
        
        [RealName("visualizerDefinition")]
        public Handle<GameinteractionsvisIVisualizerDefinition> VisualizerDefinition { get; set; }
    }
}
