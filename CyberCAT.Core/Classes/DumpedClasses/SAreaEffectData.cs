using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SAreaEffectData")]
    public class SAreaEffectData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("action")]
        public Handle<ScriptableDeviceAction> Action { get; set; }
        
        [RealName("areaEffectID")]
        public CName AreaEffectID { get; set; }
        
        [RealName("indicatorEffectName")]
        public CName IndicatorEffectName { get; set; }
        
        [RealName("useIndicatorEffect")]
        public bool UseIndicatorEffect { get; set; }
        
        [RealName("indicatorEffectSize")]
        public float IndicatorEffectSize { get; set; }
        
        [RealName("stimRange")]
        public float StimRange { get; set; }
        
        [RealName("stimLifetime")]
        public float StimLifetime { get; set; }
        
        [RealName("stimType")]
        public DumpedEnums.DeviceStimType? StimType { get; set; }
        
        [RealName("stimSource")]
        public NodeRef StimSource { get; set; }
        
        [RealName("additionaStimSources")]
        public NodeRef[] AdditionaStimSources { get; set; }
        
        [RealName("investigateSpot")]
        public NodeRef InvestigateSpot { get; set; }
        
        [RealName("investigateController")]
        public bool InvestigateController { get; set; }
        
        [RealName("controllerSource")]
        public NodeRef ControllerSource { get; set; }
        
        [RealName("highlightTargets")]
        public bool HighlightTargets { get; set; }
        
        [RealName("highlightType")]
        public DumpedEnums.EFocusForcedHighlightType? HighlightType { get; set; }
        
        [RealName("highlightPriority")]
        public DumpedEnums.EPriority? HighlightPriority { get; set; }
        
        [RealName("effectInstance")]
        public Handle<GameEffectInstance> EffectInstance { get; set; }
    }
}
