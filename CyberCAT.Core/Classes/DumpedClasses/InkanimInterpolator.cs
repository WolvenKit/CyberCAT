using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("inkanimInterpolator")]
    public class InkanimInterpolator : IScriptable
    {
        [RealName("useRelativeDuration")]
        public bool UseRelativeDuration { get; set; }
        
        [RealName("isAdditive")]
        public bool IsAdditive { get; set; }
        
        [RealName("startDelay")]
        public float StartDelay { get; set; }
        
        [RealName("duration")]
        public float Duration { get; set; }
        
        [RealName("interpolationMode")]
        public DumpedEnums.inkanimInterpolationMode? InterpolationMode { get; set; }
        
        [RealName("interpolationType")]
        public DumpedEnums.inkanimInterpolationType? InterpolationType { get; set; }
        
        [RealName("interpolationDirection")]
        public DumpedEnums.inkanimInterpolationDirection? InterpolationDirection { get; set; }
    }
}
