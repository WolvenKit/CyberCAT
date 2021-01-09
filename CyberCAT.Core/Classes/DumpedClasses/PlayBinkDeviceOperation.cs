using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("PlayBinkDeviceOperation")]
    public class PlayBinkDeviceOperation : DeviceOperationBase
    {
        [RealName("bink")]
        public SBinkperationData Bink { get; set; }
    }
}
