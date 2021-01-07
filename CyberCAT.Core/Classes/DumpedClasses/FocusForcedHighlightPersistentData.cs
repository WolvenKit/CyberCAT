using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("FocusForcedHighlightPersistentData")]
    public class FocusForcedHighlightPersistentData : IScriptable
    {
        [RealName("sourceID")]
        public EntEntityID SourceID { get; set; }
        
        [RealName("sourceName")]
        [RealType("CName")]
        public string SourceName { get; set; }
        
        [RealName("highlightType")]
        public DumpedEnums.EFocusForcedHighlightType? HighlightType { get; set; }
        
        [RealName("outlineType")]
        public DumpedEnums.EFocusOutlineType? OutlineType { get; set; }
        
        [RealName("priority")]
        public DumpedEnums.EPriority? Priority { get; set; }
        
        [RealName("inTransitionTime")]
        [RealType("Float")]
        public float InTransitionTime { get; set; }
        
        [RealName("outTransitionTime")]
        [RealType("Float")]
        public float OutTransitionTime { get; set; }
        
        [RealName("isRevealed")]
        [RealType("Bool")]
        public bool IsRevealed { get; set; }
        
        [RealName("patternType")]
        public DumpedEnums.gameVisionModePatternType? PatternType { get; set; }
    }
}
