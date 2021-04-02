using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("entRagdollImpactPointData")]
    public class EntRagdollImpactPointData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("worldPosition")]
        public WorldPosition WorldPosition { get; set; }
        
        [RealName("worldNormal")]
        public Vector4 WorldNormal { get; set; }
        
        [RealName("forceMagnitude")]
        public float ForceMagnitude { get; set; }
        
        [RealName("impulseMagnitude")]
        public float ImpulseMagnitude { get; set; }
        
        [RealName("maxForceMagnitude")]
        public float MaxForceMagnitude { get; set; }
        
        [RealName("maxImpulseMagnitude")]
        public float MaxImpulseMagnitude { get; set; }
        
        [RealName("velocityChange")]
        public float VelocityChange { get; set; }
        
        [RealName("ragdollProxyActorIndex")]
        public uint RagdollProxyActorIndex { get; set; }
        
        [RealName("otherProxyActorIndex")]
        public uint OtherProxyActorIndex { get; set; }
    }
}
