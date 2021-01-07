using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("BlindingLightControllerPS")]
    public class BlindingLightControllerPS : BasicDistractionDeviceControllerPS
    {
        [RealName("reflectorSFX")]
        public ReflectorSFX ReflectorSFX { get; set; }
    }
}
