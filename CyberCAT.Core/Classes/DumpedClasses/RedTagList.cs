using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("redTagList")]
    public class RedTagList : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("tags")]
        public CName[] Tags { get; set; }
    }
}
