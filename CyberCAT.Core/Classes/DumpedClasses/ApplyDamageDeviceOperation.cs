using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ApplyDamageDeviceOperation")]
    public class ApplyDamageDeviceOperation : DeviceOperationBase
    {
        [RealName("damages")]
        public SDamageOperationData[] Damages { get; set; }
    }
}
