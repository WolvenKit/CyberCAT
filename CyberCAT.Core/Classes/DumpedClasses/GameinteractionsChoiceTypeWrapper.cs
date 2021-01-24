using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameinteractionsChoiceTypeWrapper")]
    public class GameinteractionsChoiceTypeWrapper : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("properties")]
        public uint Properties { get; set; }
    }
}
