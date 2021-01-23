using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ExplosiveDeviceResourceDefinition")]
    public class ExplosiveDeviceResourceDefinition : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("damageType")]
        public TweakDbId DamageType { get; set; }
        
        [RealName("vfxResource")]
        public GameFxResource VfxResource { get; set; }
        
        [RealName("vfxEventNamesOnExplosion")]
        public CName[] VfxEventNamesOnExplosion { get; set; }
        
        [RealName("vfxResourceOnFirstHit")]
        public GameFxResource[] VfxResourceOnFirstHit { get; set; }
        
        [RealName("executionDelay")]
        public float ExecutionDelay { get; set; }
        
        [RealName("additionalGameEffectType")]
        public DumpedEnums.EExplosiveAdditionalGameEffectType? AdditionalGameEffectType { get; set; }
        
        [RealName("dontHighlightOnLookat")]
        public bool DontHighlightOnLookat { get; set; }
    }
}
