using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DetectionParameters")]
    public class DetectionParameters : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("canDetectIntruders")]
        public bool CanDetectIntruders { get; set; }
        
        [RealName("timeToActionAfterSpot")]
        public float TimeToActionAfterSpot { get; set; }
        
        [RealName("overrideRootRotation")]
        public float OverrideRootRotation { get; set; }
        
        [RealName("maxRotationAngle")]
        public float MaxRotationAngle { get; set; }
        
        [RealName("pitchAngle")]
        public float PitchAngle { get; set; }
        
        [RealName("rotationSpeed")]
        public float RotationSpeed { get; set; }
    }
}
