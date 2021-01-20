using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameSceneTier3Data")]
    public class GameSceneTier3Data : GameSceneTierDataMotionConstrained
    {
        [RealName("cameraSettings")]
        public GameTier3CameraSettings CameraSettings { get; set; }
    }
}
