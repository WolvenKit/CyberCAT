using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("FanControllerPS")]
    public class FanControllerPS : BasicDistractionDeviceControllerPS
    {
        [RealName("fanSetup")]
        public FanSetup FanSetup { get; set; }
    }
}
