using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("DisassembleOptions")]
    public class DisassembleOptions : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("canBeDisassembled")]
        [RealType("Bool")]
        public bool CanBeDisassembled { get; set; }
    }
}
