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
        [RealType("Bool")]
        public bool RotateClockwise { get; set; }
        
        [RealName("randomizeBladesSpeed")]
        [RealType("Bool")]
        public bool RandomizeBladesSpeed { get; set; }
        
        [RealName("maxRotationSpeed")]
        [RealType("Float")]
        public float MaxRotationSpeed { get; set; }
        
        [RealName("timeToMaxRotation")]
        [RealType("Float")]
        public float TimeToMaxRotation { get; set; }
    }
}
