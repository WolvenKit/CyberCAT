using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("STransformAnimationData")]
    public class STransformAnimationData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("animationName")]
        public CName AnimationName { get; set; }
        
        [RealName("operationType")]
        public DumpedEnums.ETransformAnimationOperationType? OperationType { get; set; }
        
        [RealName("playData")]
        public STransformAnimationPlayEventData PlayData { get; set; }
        
        [RealName("skipData")]
        public STransformAnimationSkipEventData SkipData { get; set; }
    }
}
