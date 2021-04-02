using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("PlayerVisionModeControllerOtherVars")]
    public class PlayerVisionModeControllerOtherVars : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("enabledByToggle")]
        public bool EnabledByToggle { get; set; }
        
        [RealName("active")]
        public bool Active { get; set; }
        
        [RealName("toggledDuringHold")]
        public bool ToggledDuringHold { get; set; }
    }
}
