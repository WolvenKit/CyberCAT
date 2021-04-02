using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameeventsHitEvent")]
    public class GameeventsHitEvent : RedEvent
    {
        [RealName("wasAliveBeforeHit")]
        public bool WasAliveBeforeHit { get; set; }
        
        [RealName("projectionPipeline")]
        public bool ProjectionPipeline { get; set; }
        
        [RealName("attackData")]
        public Handle<GamedamageAttackData> AttackData { get; set; }
        
        [RealName("target")]
        public GameObject Target { get; set; }
        
        [RealName("hitPosition")]
        public Vector4 HitPosition { get; set; }
        
        [RealName("hitDirection")]
        public Vector4 HitDirection { get; set; }
        
        [RealName("hitComponent")]
        public EntIPlacedComponent HitComponent { get; set; }
        
        [RealName("hitColliderTag")]
        public CName HitColliderTag { get; set; }
        
        [RealName("hitRepresentationResult")]
        public GameQueryResult HitRepresentationResult { get; set; }
        
        [RealName("attackPentration")]
        public float AttackPentration { get; set; }
        
        [RealName("hasPiercedTechSurface")]
        public bool HasPiercedTechSurface { get; set; }
        
        [RealName("attackComputed")]
        public Handle<GameAttackComputed> AttackComputed { get; set; }
    }
}
