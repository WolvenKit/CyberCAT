using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("Time")]
    public class Time : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("days")]
        [RealType("Int32")]
        public int Days { get; set; }
        
        [RealName("hours")]
        [RealType("Int32")]
        public int Hours { get; set; }
        
        [RealName("minutes")]
        [RealType("Int32")]
        public int Minutes { get; set; }
    }
}
