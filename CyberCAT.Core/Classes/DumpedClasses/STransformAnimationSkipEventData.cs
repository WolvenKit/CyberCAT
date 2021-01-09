using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("STransformAnimationSkipEventData")]
    public class STransformAnimationSkipEventData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("time")]
        [RealType("Float")]
        public float Time { get; set; }
        
        [RealName("skipToEnd")]
        [RealType("Bool")]
        public bool SkipToEnd { get; set; }
    }
}
