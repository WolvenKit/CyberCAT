using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("animLookAtRequest")]
    public class AnimLookAtRequest : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("transitionSpeed")]
        public float TransitionSpeed { get; set; }
        
        [RealName("hasOutTransition")]
        public bool HasOutTransition { get; set; }
        
        [RealName("outTransitionSpeed")]
        public float OutTransitionSpeed { get; set; }
        
        [RealName("followingSpeedFactorOverride")]
        public float FollowingSpeedFactorOverride { get; set; }
        
        [RealName("limits")]
        public AnimLookAtLimits Limits { get; set; }
        
        [RealName("suppress")]
        public float Suppress { get; set; }
        
        [RealName("mode")]
        public int Mode { get; set; }
        
        [RealName("calculatePositionInParentSpace")]
        public bool CalculatePositionInParentSpace { get; set; }
        
        [RealName("priority")]
        public int Priority { get; set; }
        
        [RealName("additionalParts")]
        public AnimLookAtPartRequest AdditionalParts { get; set; }
        
        [RealName("invalid")]
        public bool Invalid { get; set; }
    }
}
