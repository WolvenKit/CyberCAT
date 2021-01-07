using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("WindowBlindersData")]
    public class WindowBlindersData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("windowBlindersState")]
        public DumpedEnums.EWindowBlindersStates? WindowBlindersState { get; set; }
        
        [RealName("hasOpenInteraction")]
        [RealType("Bool")]
        public bool HasOpenInteraction { get; set; }
        
        [RealName("hasTiltInteraction")]
        [RealType("Bool")]
        public bool HasTiltInteraction { get; set; }
        
        [RealName("hasQuickHack")]
        [RealType("Bool")]
        public bool HasQuickHack { get; set; }
    }
}
