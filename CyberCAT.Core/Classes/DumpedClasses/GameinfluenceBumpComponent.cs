using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameinfluenceBumpComponent")]
    public class GameinfluenceBumpComponent : EntIPlacedComponent
    {
        [RealName("isBumpable")]
        public bool IsBumpable { get; set; }
        
        [RealName("isEnabled")]
        public bool IsEnabled { get; set; }
        
        [RealName("autoPlayBumpAnimation")]
        public bool AutoPlayBumpAnimation { get; set; }
        
        [RealName("isPlayerControlled")]
        public bool IsPlayerControlled { get; set; }
        
        [RealName("movementSpreadDistance")]
        public float MovementSpreadDistance { get; set; }
        
        [RealName("movementSpreadRadius")]
        public float MovementSpreadRadius { get; set; }
        
        [RealName("distanceToReactBack")]
        public float DistanceToReactBack { get; set; }
        
        [RealName("distanceToReactFront")]
        public float DistanceToReactFront { get; set; }
        
        [RealName("reactionSettings")]
        public GameinfluenceBumpReactionSetting[] ReactionSettings { get; set; }
    }
}
