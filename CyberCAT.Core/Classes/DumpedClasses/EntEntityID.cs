using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("entEntityID")]
    public class EntEntityID : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("hash")]
        public ulong Hash { get; set; }
    }
}
