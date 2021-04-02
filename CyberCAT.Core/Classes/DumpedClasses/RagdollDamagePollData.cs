using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("RagdollDamagePollData")]
    public class RagdollDamagePollData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("worldPosition")]
        public WorldPosition WorldPosition { get; set; }
        
        [RealName("worldNormal")]
        public Vector4 WorldNormal { get; set; }
        
        [RealName("maxForceMagnitude")]
        public float MaxForceMagnitude { get; set; }
        
        [RealName("maxImpulseMagnitude")]
        public float MaxImpulseMagnitude { get; set; }
        
        [RealName("maxVelocityChange")]
        public float MaxVelocityChange { get; set; }
        
        [RealName("maxZDiff")]
        public float MaxZDiff { get; set; }
    }
}
