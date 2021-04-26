using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("PlayerVisionModeControllerInputActionsNames")]
    public class PlayerVisionModeControllerInputActionsNames : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("buttonHold")]
        public CName ButtonHold { get; set; }
        
        [RealName("buttonToggle")]
        public CName ButtonToggle { get; set; }
    }
}
