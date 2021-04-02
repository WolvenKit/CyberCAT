using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("entVoicesetInputToBlock")]
    public class EntVoicesetInputToBlock : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("input")]
        public CName Input { get; set; }
        
        [RealName("variationNumber")]
        public uint VariationNumber { get; set; }
        
        [RealName("blockSpecificVariation")]
        public bool BlockSpecificVariation { get; set; }
    }
}
