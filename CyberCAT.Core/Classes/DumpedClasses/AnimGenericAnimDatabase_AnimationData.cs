using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("animGenericAnimDatabase_AnimationData")]
    public class AnimGenericAnimDatabase_AnimationData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("animationName")]
        public CName AnimationName { get; set; }
        
        [RealName("fallbackAnimationName")]
        public CName FallbackAnimationName { get; set; }
        
        [RealName("streamingContext")]
        public CName StreamingContext { get; set; }
    }
}
