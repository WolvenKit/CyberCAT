using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ExplosiveDeviceResourceDefinition")]
    public class ExplosiveDeviceResourceDefinition : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("damageType")]
        [RealType("TweakDBID")]
        public TweakDbId DamageType { get; set; }
        
        [RealName("vfxResource")]
        public GameFxResource VfxResource { get; set; }
        
        [RealName("vfxEventNamesOnExplosion")]
        [RealType("CName")]
        public string[] VfxEventNamesOnExplosion { get; set; }
        
        [RealName("vfxResourceOnFirstHit")]
        public GameFxResource[] VfxResourceOnFirstHit { get; set; }
        
        [RealName("executionDelay")]
        [RealType("Float")]
        public float ExecutionDelay { get; set; }
        
        [RealName("additionalGameEffectType")]
        public DumpedEnums.EExplosiveAdditionalGameEffectType? AdditionalGameEffectType { get; set; }
        
        [RealName("dontHighlightOnLookat")]
        [RealType("Bool")]
        public bool DontHighlightOnLookat { get; set; }
    }
}
