using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("inkMargin")]
    public class InkMargin : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("left")]
        public float Left { get; set; }
        
        [RealName("top")]
        public float Top { get; set; }
        
        [RealName("right")]
        public float Right { get; set; }
        
        [RealName("bottom")]
        public float Bottom { get; set; }
    }
}
