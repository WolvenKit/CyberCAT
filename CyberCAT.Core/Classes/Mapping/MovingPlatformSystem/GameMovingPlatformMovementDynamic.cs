namespace CyberCAT.Core.Classes.Mapping.MovingPlatformSystem
{
    [RealName("gameMovingPlatformMovementDynamic")]
    public class GameMovingPlatformMovementDynamic : GameIMovingPlatformMovementPointToPoint
    {
        [RealName("curveName")]
        [RealType("CName")]
        public string CurveName { get; set; }
    }
}