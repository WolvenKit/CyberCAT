using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("PlaySoundDeviceOperation")]
    public class PlaySoundDeviceOperation : DeviceOperationBase
    {
        [RealName("SFXs")]
        public SSFXOperationData[] SFXs { get; set; }
    }
}
