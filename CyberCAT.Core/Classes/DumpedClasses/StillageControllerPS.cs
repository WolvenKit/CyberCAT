using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("StillageControllerPS")]
    public class StillageControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("isCleared")]
        public bool IsCleared { get; set; }
    }
}
