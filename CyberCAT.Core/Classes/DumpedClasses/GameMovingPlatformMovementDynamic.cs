using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameMovingPlatformMovementDynamic")]
    public class GameMovingPlatformMovementDynamic : GameIMovingPlatformMovementPointToPoint
    {
        [RealName("curveName")]
        public CName CurveName { get; set; }
    }
}
