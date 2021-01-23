using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DeviceOperationBase")]
    public class DeviceOperationBase : IScriptable
    {
        [RealName("operationName")]
        public CName OperationName { get; set; }
        
        [RealName("executeOnce")]
        public bool ExecuteOnce { get; set; }
        
        [RealName("isEnabled")]
        public bool IsEnabled { get; set; }
        
        [RealName("toggleOperations")]
        public SToggleDeviceOperationData[] ToggleOperations { get; set; }
        
        [RealName("disableDevice")]
        public bool DisableDevice { get; set; }
    }
}
