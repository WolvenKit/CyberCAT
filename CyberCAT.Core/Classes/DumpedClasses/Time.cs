using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("Time")]
    public class Time : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("days")]
        public int Days { get; set; }
        
        [RealName("hours")]
        public int Hours { get; set; }
        
        [RealName("minutes")]
        public int Minutes { get; set; }
    }
}
