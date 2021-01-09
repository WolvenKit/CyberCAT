using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DetectionParameters")]
    public class DetectionParameters : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("canDetectIntruders")]
        [RealType("Bool")]
        public bool CanDetectIntruders { get; set; }
        
        [RealName("timeToActionAfterSpot")]
        [RealType("Float")]
        public float TimeToActionAfterSpot { get; set; }
        
        [RealName("overrideRootRotation")]
        [RealType("Float")]
        public float OverrideRootRotation { get; set; }
        
        [RealName("maxRotationAngle")]
        [RealType("Float")]
        public float MaxRotationAngle { get; set; }
        
        [RealName("pitchAngle")]
        [RealType("Float")]
        public float PitchAngle { get; set; }
        
        [RealName("rotationSpeed")]
        [RealType("Float")]
        public float RotationSpeed { get; set; }
    }
}
