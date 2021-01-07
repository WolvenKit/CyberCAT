using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("VendingMachineSFX")]
    public class VendingMachineSFX : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("glitchingStart")]
        [RealType("CName")]
        public string GlitchingStart { get; set; }
        
        [RealName("glitchingStop")]
        [RealType("CName")]
        public string GlitchingStop { get; set; }
    }
}
