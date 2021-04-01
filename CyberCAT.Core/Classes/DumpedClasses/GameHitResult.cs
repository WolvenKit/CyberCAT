using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameHitResult")]
    public class GameHitResult : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("hitPositionEnter")]
        public Vector4 HitPositionEnter { get; set; }
        
        [RealName("hitPositionExit")]
        public Vector4 HitPositionExit { get; set; }
        
        [RealName("enterDistanceFromOriginSq")]
        public float EnterDistanceFromOriginSq { get; set; }
    }
}
