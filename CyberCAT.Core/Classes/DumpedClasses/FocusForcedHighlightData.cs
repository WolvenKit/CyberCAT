using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("FocusForcedHighlightData")]
    public class FocusForcedHighlightData : IScriptable
    {
        [RealName("sourceID")]
        public EntEntityID SourceID { get; set; }
        
        [RealName("sourceName")]
        public CName SourceName { get; set; }
        
        [RealName("highlightType")]
        public DumpedEnums.EFocusForcedHighlightType? HighlightType { get; set; }
        
        [RealName("outlineType")]
        public DumpedEnums.EFocusOutlineType? OutlineType { get; set; }
        
        [RealName("priority")]
        public DumpedEnums.EPriority? Priority { get; set; }
        
        [RealName("inTransitionTime")]
        public float InTransitionTime { get; set; }
        
        [RealName("outTransitionTime")]
        public float OutTransitionTime { get; set; }
        
        [RealName("hudData")]
        public Handle<HighlightInstance> HudData { get; set; }
        
        [RealName("isRevealed")]
        public bool IsRevealed { get; set; }
        
        [RealName("isSavable")]
        public bool IsSavable { get; set; }
        
        [RealName("patternType")]
        public DumpedEnums.gameVisionModePatternType? PatternType { get; set; }
    }
}
