using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DeviceOperationsContainer")]
    public class DeviceOperationsContainer : IScriptable
    {
        [RealName("operations")]
        public Handle<DeviceOperationBase>[] Operations { get; set; }
        
        [RealName("triggers")]
        public Handle<DeviceOperationsTrigger>[] Triggers { get; set; }
    }
}
