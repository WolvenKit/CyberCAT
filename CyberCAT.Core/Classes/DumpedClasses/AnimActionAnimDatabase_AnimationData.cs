using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("animActionAnimDatabase_AnimationData")]
    public class AnimActionAnimDatabase_AnimationData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("animationName")]
        public CName AnimationName { get; set; }
        
        [RealName("fallbackAnimationName")]
        public CName FallbackAnimationName { get; set; }
        
        [RealName("streamingContext")]
        public CName StreamingContext { get; set; }
        
        [RealName("inTransitionDuration")]
        public float InTransitionDuration { get; set; }
        
        [RealName("outTransitionDuration")]
        public float OutTransitionDuration { get; set; }
        
        [RealName("inCanRequestInertialization")]
        public bool InCanRequestInertialization { get; set; }
        
        [RealName("outCanRequestInertialization")]
        public bool OutCanRequestInertialization { get; set; }
    }
}
