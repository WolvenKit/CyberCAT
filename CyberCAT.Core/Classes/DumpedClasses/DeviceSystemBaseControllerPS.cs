using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DeviceSystemBaseControllerPS")]
    public class DeviceSystemBaseControllerPS : MasterControllerPS
    {
        [RealName("quickHacksEnabled")]
        [RealType("Bool")]
        public bool QuickHacksEnabled { get; set; }
    }
}
