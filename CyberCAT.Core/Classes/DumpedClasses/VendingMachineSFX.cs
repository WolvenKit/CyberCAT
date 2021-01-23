using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("VendingMachineSFX")]
    public class VendingMachineSFX : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("glitchingStart")]
        public CName GlitchingStart { get; set; }
        
        [RealName("glitchingStop")]
        public CName GlitchingStop { get; set; }
    }
}
