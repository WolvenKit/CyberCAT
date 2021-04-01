using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameFPPCameraComponent")]
    public class GameFPPCameraComponent : GameCameraComponent
    {
        [RealName("pitchMin")]
        public float PitchMin { get; set; }
        
        [RealName("pitchMax")]
        public float PitchMax { get; set; }
        
        [RealName("yawMaxLeft")]
        public float YawMaxLeft { get; set; }
        
        [RealName("yawMaxRight")]
        public float YawMaxRight { get; set; }
        
        [RealName("headingLocked")]
        public bool HeadingLocked { get; set; }
        
        [RealName("sensitivityMultX")]
        public float SensitivityMultX { get; set; }
        
        [RealName("sensitivityMultY")]
        public float SensitivityMultY { get; set; }
        
        [RealName("timeDilationCurveName")]
        public CName TimeDilationCurveName { get; set; }
    }
}
