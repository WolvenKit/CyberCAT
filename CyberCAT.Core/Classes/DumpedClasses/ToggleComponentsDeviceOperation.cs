using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ToggleComponentsDeviceOperation")]
    public class ToggleComponentsDeviceOperation : DeviceOperationBase
    {
        [RealName("components")]
        public SComponentOperationData[] Components { get; set; }

        public ToggleComponentsDeviceOperation()
        {
            IsEnabled = true;
        }
    }
}
