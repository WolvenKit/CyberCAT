using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("BillboardDeviceControllerPS")]
    public class BillboardDeviceControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("glitchSFX")]
        public CName GlitchSFX { get; set; }
        
        [RealName("useLights")]
        public bool UseLights { get; set; }
        
        [RealName("lightsSettings")]
        public EditableGameLightSettings[] LightsSettings { get; set; }
        
        [RealName("useDeviceAppearence")]
        public bool UseDeviceAppearence { get; set; }
    }
}
