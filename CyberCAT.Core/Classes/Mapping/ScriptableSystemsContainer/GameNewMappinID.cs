using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("gameNewMappinID")]
    public class GameNewMappinID : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("value")]
        [RealType("Uint64")]
        public ulong Value { get; set; }
    }
}
