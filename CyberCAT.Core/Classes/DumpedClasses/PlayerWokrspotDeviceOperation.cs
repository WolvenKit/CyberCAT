using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("PlayerWokrspotDeviceOperation")]
    public class PlayerWokrspotDeviceOperation : DeviceOperationBase
    {
        [RealName("playerWorkspot")]
        public SWorkspotData PlayerWorkspot { get; set; }
    }
}
