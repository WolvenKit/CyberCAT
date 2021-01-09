using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameNewMappinID")]
    public class GameNewMappinID : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("value")]
        [RealType("Uint64")]
        public ulong Value { get; set; }
    }
}
