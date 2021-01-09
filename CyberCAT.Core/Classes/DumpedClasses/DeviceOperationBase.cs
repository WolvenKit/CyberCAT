using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DeviceOperationBase")]
    public class DeviceOperationBase : IScriptable
    {
        [RealName("operationName")]
        [RealType("CName")]
        public string OperationName { get; set; }
        
        [RealName("executeOnce")]
        [RealType("Bool")]
        public bool ExecuteOnce { get; set; }
        
        [RealName("isEnabled")]
        [RealType("Bool")]
        public bool IsEnabled { get; set; }
        
        [RealName("toggleOperations")]
        public SToggleDeviceOperationData[] ToggleOperations { get; set; }
        
        [RealName("disableDevice")]
        [RealType("Bool")]
        public bool DisableDevice { get; set; }
    }
}
