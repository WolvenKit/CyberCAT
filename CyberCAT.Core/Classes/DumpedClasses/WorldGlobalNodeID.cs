using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("worldGlobalNodeID")]
    public class WorldGlobalNodeID : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("hash")]
        public ulong Hash { get; set; }
    }
}
