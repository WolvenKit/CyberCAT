using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("FanSetup")]
    public class FanSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("animationType")]
        public DumpedEnums.EAnimationType? AnimationType { get; set; }
        
        [RealName("rotateClockwise")]
        public bool RotateClockwise { get; set; }
        
        [RealName("randomizeBladesSpeed")]
        public bool RandomizeBladesSpeed { get; set; }
        
        [RealName("maxRotationSpeed")]
        public float MaxRotationSpeed { get; set; }
        
        [RealName("timeToMaxRotation")]
        public float TimeToMaxRotation { get; set; }
    }
}
