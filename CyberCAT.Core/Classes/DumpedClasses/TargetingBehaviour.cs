using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("TargetingBehaviour")]
    public class TargetingBehaviour : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("initialWakeState")]
        [RealType("ESensorDeviceWakeState")]
        public DumpedEnums.ESensorDeviceWakeState? InitialWakeState { get; set; }
        
        [RealName("canRotate")]
        public bool CanRotate { get; set; }
        
        [RealName("lostTargetLookAtTime")]
        public float LostTargetLookAtTime { get; set; }
        
        [RealName("lostTargetSearchTime")]
        public float LostTargetSearchTime { get; set; }
    }
}
