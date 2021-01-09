using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("StillageControllerPS")]
    public class StillageControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("isCleared")]
        [RealType("Bool")]
        public bool IsCleared { get; set; }
    }
}
