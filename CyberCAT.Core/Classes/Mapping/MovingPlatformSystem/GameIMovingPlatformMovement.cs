using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.MovingPlatformSystem
{
    [RealName("gameIMovingPlatformMovement")]
    public class GameIMovingPlatformMovement : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("initData")]
        public GameIMovingPlatformMovementInitData InitData { get; set; }
    }
}