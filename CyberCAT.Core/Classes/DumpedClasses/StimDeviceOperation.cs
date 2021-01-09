using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("StimDeviceOperation")]
    public class StimDeviceOperation : DeviceOperationBase
    {
        [RealName("stims")]
        public SStimOperationData[] Stims { get; set; }
    }
}
