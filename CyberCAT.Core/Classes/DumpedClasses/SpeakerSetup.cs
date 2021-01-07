using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SpeakerSetup")]
    public class SpeakerSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("defaultMusic")]
        public DumpedEnums.ERadioStationList? DefaultMusic { get; set; }
        
        [RealName("distractionMusic")]
        public DumpedEnums.ERadioStationList? DistractionMusic { get; set; }
        
        [RealName("range")]
        [RealType("Float")]
        public float Range { get; set; }
        
        [RealName("glitchSFX")]
        [RealType("CName")]
        public string GlitchSFX { get; set; }
        
        [RealName("useOnlyGlitchSFX")]
        [RealType("Bool")]
        public bool UseOnlyGlitchSFX { get; set; }
    }
}
