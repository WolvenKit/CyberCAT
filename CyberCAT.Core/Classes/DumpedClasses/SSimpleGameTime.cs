using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SSimpleGameTime")]
    public class SSimpleGameTime : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("hours")]
        [RealType("Int32")]
        public int Hours { get; set; }
        
        [RealName("minutes")]
        [RealType("Int32")]
        public int Minutes { get; set; }
        
        [RealName("seconds")]
        [RealType("Int32")]
        public int Seconds { get; set; }
    }
}
