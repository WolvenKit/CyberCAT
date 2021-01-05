using CyberCAT.Core.Classes.Mapping.Global;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
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
