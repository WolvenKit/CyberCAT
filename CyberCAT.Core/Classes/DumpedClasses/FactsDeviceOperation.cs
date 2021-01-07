using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("FactsDeviceOperation")]
    public class FactsDeviceOperation : DeviceOperationBase
    {
        [RealName("facts")]
        public SFactOperationData[] Facts { get; set; }
    }
}
