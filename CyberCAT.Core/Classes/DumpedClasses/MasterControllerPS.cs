using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("MasterControllerPS")]
    public class MasterControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("clearance")]
        public Handle<GamedeviceClearance> Clearance { get; set; }
    }
}
