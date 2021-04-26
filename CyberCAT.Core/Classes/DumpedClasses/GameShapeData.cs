using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameShapeData")]
    public class GameShapeData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("result")]
        public GameHitResult Result { get; set; }
        
        [RealName("userData")]
        public Handle<GameHitShapeUserData> UserData { get; set; }
        
        [RealName("physicsMaterial")]
        public CName PhysicsMaterial { get; set; }
        
        [RealName("hitShapeName")]
        public CName HitShapeName { get; set; }
    }
}
