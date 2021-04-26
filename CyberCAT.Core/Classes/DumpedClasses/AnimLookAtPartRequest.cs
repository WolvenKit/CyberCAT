using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("animLookAtPartRequest")]
    public class AnimLookAtPartRequest : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("partName")]
        public CName PartName { get; set; }
        
        [RealName("weight")]
        public float Weight { get; set; }
        
        [RealName("suppress")]
        public float Suppress { get; set; }
        
        [RealName("mode")]
        public int Mode { get; set; }
    }
}
