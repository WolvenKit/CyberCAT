using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameuiMinigameProgramData")]
    public class GameuiMinigameProgramData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("actionID")]
        public TweakDbId ActionID { get; set; }
        
        [RealName("programName")]
        public CName ProgramName { get; set; }
    }
}
