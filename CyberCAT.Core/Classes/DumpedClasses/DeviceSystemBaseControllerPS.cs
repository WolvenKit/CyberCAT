using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DeviceSystemBaseControllerPS")]
    public class DeviceSystemBaseControllerPS : MasterControllerPS
    {
        [RealName("quickHacksEnabled")]
        public bool QuickHacksEnabled { get; set; }
    }
}
