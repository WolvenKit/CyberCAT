using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ResourceLibraryComponent")]
    public class ResourceLibraryComponent : GameScriptableComponent
    {
        [RealName("resources")]
        public FxResourceMapData[] Resources { get; set; }
    }
}
