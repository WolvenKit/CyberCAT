using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ElectricLightControllerPS")]
    public class ElectricLightControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("isConnectedToCLS")]
        [RealType("Bool")]
        public bool IsConnectedToCLS { get; set; }
        
        [RealName("wasCLSInitTriggered")]
        [RealType("Bool")]
        public bool WasCLSInitTriggered { get; set; }
    }
}
