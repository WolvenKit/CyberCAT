using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SSimpleGameTime")]
    public class SSimpleGameTime : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("hours")]
        public int Hours { get; set; }
        
        [RealName("minutes")]
        public int Minutes { get; set; }
        
        [RealName("seconds")]
        public int Seconds { get; set; }
    }
}
