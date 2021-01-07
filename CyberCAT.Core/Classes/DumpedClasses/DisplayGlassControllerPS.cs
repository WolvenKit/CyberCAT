using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DisplayGlassControllerPS")]
    public class DisplayGlassControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("isTinted")]
        [RealType("Bool")]
        public bool IsTinted { get; set; }
        
        [RealName("useAppearances")]
        [RealType("Bool")]
        public bool UseAppearances { get; set; }
        
        [RealName("clearAppearance")]
        [RealType("CName")]
        public string ClearAppearance { get; set; }
        
        [RealName("tintedAppearance")]
        [RealType("CName")]
        public string TintedAppearance { get; set; }
    }
}
