using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DestructibleMasterDeviceControllerPS")]
    public class DestructibleMasterDeviceControllerPS : MasterControllerPS
    {
        [RealName("isDestroyed")]
        public bool IsDestroyed { get; set; }
    }
}
