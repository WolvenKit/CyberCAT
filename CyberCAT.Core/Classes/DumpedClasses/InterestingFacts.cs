using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("InterestingFacts")]
    public class InterestingFacts : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("zone")]
        public CName Zone { get; set; }
    }
}
