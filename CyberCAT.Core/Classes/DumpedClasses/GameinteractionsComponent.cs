using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameinteractionsComponent")]
    public class GameinteractionsComponent : EntIPlacedComponent
    {
        [RealName("isEnabled")]
        public bool IsEnabled { get; set; }
        
        [RealName("definitionResource")]
        public GameinteractionsInteractionDescriptorResource DefinitionResource { get; set; }
        
        [RealName("interactionRootOffset")]
        public Vector3 InteractionRootOffset { get; set; }
        
        [RealName("layerOverrides")]
        public GameinteractionsInteractionDefinitionOverrider[] LayerOverrides { get; set; }
        
        [RealName("layerOverridesTemp")]
        public GameinteractionsInteractionDefinitionOverrider[] LayerOverridesTemp { get; set; }
    }
}
