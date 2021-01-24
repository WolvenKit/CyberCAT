using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameNewMappinID")]
    public class GameNewMappinID : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("value")]
        public ulong Value { get; set; }
    }
}
