using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("physicsCustomFilterData")]
    public class PhysicsCustomFilterData : ISerializable
    {
        [RealName("collisionType")]
        public CName[] CollisionType { get; set; }
        
        [RealName("collideWith")]
        public CName[] CollideWith { get; set; }
        
        [RealName("queryDetect")]
        public CName[] QueryDetect { get; set; }
    }
}
