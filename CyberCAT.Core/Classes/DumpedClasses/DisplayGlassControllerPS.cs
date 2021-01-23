using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DisplayGlassControllerPS")]
    public class DisplayGlassControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("isTinted")]
        public bool IsTinted { get; set; }
        
        [RealName("useAppearances")]
        public bool UseAppearances { get; set; }
        
        [RealName("clearAppearance")]
        public CName ClearAppearance { get; set; }
        
        [RealName("tintedAppearance")]
        public CName TintedAppearance { get; set; }
    }
}
