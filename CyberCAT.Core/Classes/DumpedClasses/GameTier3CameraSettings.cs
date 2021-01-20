using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameTier3CameraSettings")]
    public class GameTier3CameraSettings : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("yawLeftLimit")]
        [RealType("Float")]
        public float YawLeftLimit { get; set; }
        
        [RealName("yawRightLimit")]
        [RealType("Float")]
        public float YawRightLimit { get; set; }
        
        [RealName("pitchTopLimit")]
        [RealType("Float")]
        public float PitchTopLimit { get; set; }
        
        [RealName("pitchBottomLimit")]
        [RealType("Float")]
        public float PitchBottomLimit { get; set; }
        
        [RealName("pitchSpeedMultiplier")]
        [RealType("Float")]
        public float PitchSpeedMultiplier { get; set; }
        
        [RealName("yawSpeedMultiplier")]
        [RealType("Float")]
        public float YawSpeedMultiplier { get; set; }
    }
}
