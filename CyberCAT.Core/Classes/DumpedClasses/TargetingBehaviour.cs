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
        [RealType("Bool")]
        public bool CanRotate { get; set; }
        
        [RealName("lostTargetLookAtTime")]
        [RealType("Float")]
        public float LostTargetLookAtTime { get; set; }
        
        [RealName("lostTargetSearchTime")]
        [RealType("Float")]
        public float LostTargetSearchTime { get; set; }
    }
}
