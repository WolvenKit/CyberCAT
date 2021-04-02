using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("animLookAtLimits")]
    public class AnimLookAtLimits : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("softLimitDegrees")]
        public float SoftLimitDegrees { get; set; }
        
        [RealName("hardLimitDegrees")]
        public float HardLimitDegrees { get; set; }
        
        [RealName("hardLimitDistance")]
        public float HardLimitDistance { get; set; }
        
        [RealName("backLimitDegrees")]
        public float BackLimitDegrees { get; set; }
    }
}
