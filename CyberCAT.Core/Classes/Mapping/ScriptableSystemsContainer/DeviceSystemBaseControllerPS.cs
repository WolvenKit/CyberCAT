
namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("DeviceSystemBaseControllerPS")]
    public class DeviceSystemBaseControllerPS : MasterControllerPS
    {
        [RealName("quickHacksEnabled")]
        [RealType("Bool")]
        public bool QuickHacksEnabled { get; set; }
    }
}
