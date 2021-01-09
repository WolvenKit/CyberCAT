using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("BillboardDeviceControllerPS")]
    public class BillboardDeviceControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("glitchSFX")]
        [RealType("CName")]
        public string GlitchSFX { get; set; }
        
        [RealName("useLights")]
        [RealType("Bool")]
        public bool UseLights { get; set; }
        
        [RealName("lightsSettings")]
        public EditableGameLightSettings[] LightsSettings { get; set; }
        
        [RealName("useDeviceAppearence")]
        [RealType("Bool")]
        public bool UseDeviceAppearence { get; set; }
    }
}
