using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameuiMinigameProgramData")]
    public class GameuiMinigameProgramData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("actionID")]
        [RealType("TweakDBID")]
        public TweakDbId ActionID { get; set; }
        
        [RealName("programName")]
        [RealType("CName")]
        public string ProgramName { get; set; }
    }
}
