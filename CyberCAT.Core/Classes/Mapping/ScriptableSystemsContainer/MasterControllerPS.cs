using CyberCAT.Core.Classes.Mapping.Global;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("MasterControllerPS")]
    public class MasterControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("clearance")]
        public Handle<GamedeviceClearance> Clearance { get; set; }
    }
}
