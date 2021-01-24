using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameTier3CameraSettings")]
    public class GameTier3CameraSettings : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("yawLeftLimit")]
        public float YawLeftLimit { get; set; }
        
        [RealName("yawRightLimit")]
        public float YawRightLimit { get; set; }
        
        [RealName("pitchTopLimit")]
        public float PitchTopLimit { get; set; }
        
        [RealName("pitchBottomLimit")]
        public float PitchBottomLimit { get; set; }
        
        [RealName("pitchSpeedMultiplier")]
        public float PitchSpeedMultiplier { get; set; }
        
        [RealName("yawSpeedMultiplier")]
        public float YawSpeedMultiplier { get; set; }
    }
}
