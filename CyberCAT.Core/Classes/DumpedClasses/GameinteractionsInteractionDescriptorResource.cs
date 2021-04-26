using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameinteractionsInteractionDescriptorResource")]
    public class GameinteractionsInteractionDescriptorResource : CResource
    {
        [RealName("definition")]
        public GameinteractionsCHotSpotDefinition Definition { get; set; }
    }
}
