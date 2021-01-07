using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SInternetData")]
    public class SInternetData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("startingPage")]
        [RealType("String")]
        public string StartingPage { get; set; }
    }
}
