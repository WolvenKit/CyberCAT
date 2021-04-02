using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("IWorldWidgetComponent")]
    public class IWorldWidgetComponent : WidgetBaseComponent
    {
        [RealName("isEnabled")]
        public bool IsEnabled { get; set; }
        
        [RealName("glitchValue")]
        public float GlitchValue { get; set; }
        
        [RealName("meshTargetBinding")]
        public Handle<WorlduiMeshTargetBinding> MeshTargetBinding { get; set; }
        
        [RealName("tintColor")]
        public Color TintColor { get; set; }
        
        [RealName("screenAreaMultiplier")]
        public float ScreenAreaMultiplier { get; set; }
    }
}
