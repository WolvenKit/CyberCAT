using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameinteractionsOrbID")]
    public class GameinteractionsOrbID : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("id")]
        public uint Id { get; set; }
    }
}
