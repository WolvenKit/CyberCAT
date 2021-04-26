using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("PlayerVisionModeControllerInputActiveFlags")]
    public class PlayerVisionModeControllerInputActiveFlags : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("buttonHold")]
        public bool ButtonHold { get; set; }
        
        [RealName("buttonToggle")]
        public bool ButtonToggle { get; set; }
    }
}
