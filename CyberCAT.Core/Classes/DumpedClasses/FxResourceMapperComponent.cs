using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("FxResourceMapperComponent")]
    public class FxResourceMapperComponent : GameScriptableComponent
    {
        [RealName("areaEffectsData")]
        public SAreaEffectData[] AreaEffectsData { get; set; }
        
        [RealName("areaEffectsInFocusMode")]
        public SAreaEffectTargetData[] AreaEffectsInFocusMode { get; set; }
        
        [RealName("areaEffectData")]
        public Handle<AreaEffectData>[] AreaEffectData { get; set; }
        
        [RealName("investigationSlotOffsetMultiplier")]
        public float InvestigationSlotOffsetMultiplier { get; set; }
        
        [RealName("areaEffectInFocusMode")]
        public Handle<AreaEffectTargetData>[] AreaEffectInFocusMode { get; set; }
        
        [RealName("DEBUG_copiedDataFromEntity")]
        public bool DEBUG_copiedDataFromEntity { get; set; }
        
        [RealName("DEBUG_copiedDataFromFXStruct")]
        public bool DEBUG_copiedDataFromFXStruct { get; set; }
    }
}
