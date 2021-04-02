using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("animAnimFeature_HitReactionsData")]
    public class AnimAnimFeature_HitReactionsData : AnimAnimFeature
    {
        [RealName("hitIntensity")]
        public int HitIntensity { get; set; }
        
        [RealName("hitSource")]
        public int HitSource { get; set; }
        
        [RealName("hitType")]
        public int HitType { get; set; }
        
        [RealName("hitBodyPart")]
        public int HitBodyPart { get; set; }
        
        [RealName("npcMovementSpeed")]
        public int NpcMovementSpeed { get; set; }
        
        [RealName("hitDirection")]
        public int HitDirection { get; set; }
        
        [RealName("npcMovementDirection")]
        public int NpcMovementDirection { get; set; }
        
        [RealName("stance")]
        public int Stance { get; set; }
        
        [RealName("animVariation")]
        public int AnimVariation { get; set; }
        
        [RealName("useInitialRotation")]
        public bool UseInitialRotation { get; set; }
        
        [RealName("hitDirectionWs")]
        public Vector4 HitDirectionWs { get; set; }
        
        [RealName("angleToAttack")]
        public float AngleToAttack { get; set; }
        
        [RealName("initialRotationDuration")]
        public float InitialRotationDuration { get; set; }
    }
}
