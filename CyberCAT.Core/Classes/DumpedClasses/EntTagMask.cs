using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("entTagMask")]
    public class EntTagMask : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("hardTags")]
        public RedTagList HardTags { get; set; }
        
        [RealName("softTags")]
        public RedTagList SoftTags { get; set; }
        
        [RealName("excludedTags")]
        public RedTagList ExcludedTags { get; set; }
    }
}
