using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("PlayerVisionModeControllerInputListeners")]
    public class PlayerVisionModeControllerInputListeners : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("buttonHold")]
        public uint ButtonHold { get; set; }
        
        [RealName("buttonToggle")]
        public uint ButtonToggle { get; set; }
    }
}
