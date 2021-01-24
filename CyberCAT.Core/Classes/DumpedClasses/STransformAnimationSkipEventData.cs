using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("STransformAnimationSkipEventData")]
    public class STransformAnimationSkipEventData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("time")]
        public float Time { get; set; }
        
        [RealName("skipToEnd")]
        public bool SkipToEnd { get; set; }
    }
}
