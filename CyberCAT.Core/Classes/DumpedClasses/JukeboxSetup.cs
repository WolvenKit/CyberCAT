using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("JukeboxSetup")]
    public class JukeboxSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("startingStation")]
        public DumpedEnums.ERadioStationList? StartingStation { get; set; }
        
        [RealName("glitchSFX")]
        public CName GlitchSFX { get; set; }
        
        [RealName("paymentRecordID")]
        public TweakDbId PaymentRecordID { get; set; }
    }
}
