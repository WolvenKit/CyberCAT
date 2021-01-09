using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DisassembleOptions")]
    public class DisassembleOptions : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("canBeDisassembled")]
        [RealType("Bool")]
        public bool CanBeDisassembled { get; set; }
    }
}
