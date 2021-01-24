using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ElectricLightControllerPS")]
    public class ElectricLightControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("isConnectedToCLS")]
        public bool IsConnectedToCLS { get; set; }
        
        [RealName("wasCLSInitTriggered")]
        public bool WasCLSInitTriggered { get; set; }
    }
}
