using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("InterestingFactsListenersIds")]
    public class InterestingFactsListenersIds : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("zone")]
        public uint Zone { get; set; }
    }
}
