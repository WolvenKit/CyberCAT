using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("animActionAnimDatabase_DatabaseRow")]
    public class AnimActionAnimDatabase_DatabaseRow : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("animFeatureName")]
        public CName AnimFeatureName { get; set; }
        
        [RealName("state")]
        public int State { get; set; }
        
        [RealName("animVariation")]
        public int AnimVariation { get; set; }
        
        [RealName("animationData")]
        public AnimActionAnimDatabase_AnimationData AnimationData { get; set; }
    }
}
