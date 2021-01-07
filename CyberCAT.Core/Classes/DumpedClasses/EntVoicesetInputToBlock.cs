using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("entVoicesetInputToBlock")]
    public class EntVoicesetInputToBlock : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("input")]
        [RealType("CName")]
        public string Input { get; set; }
        
        [RealName("blockSpecificVariation")]
        [RealType("Bool")]
        public bool BlockSpecificVariation { get; set; }
        
        [RealName("variationNumber")]
        [RealType("Uint32")]
        public uint VariationNumber { get; set; }
    }
}
