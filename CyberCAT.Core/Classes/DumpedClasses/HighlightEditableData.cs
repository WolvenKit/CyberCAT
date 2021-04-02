using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("HighlightEditableData")]
    public class HighlightEditableData : IScriptable
    {
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
        
        [RealName("isRevealed")]
        public bool IsRevealed { get; set; }
        
        [RealName("patternType")]
        public DumpedEnums.gameVisionModePatternType? PatternType { get; set; }
    }
}
