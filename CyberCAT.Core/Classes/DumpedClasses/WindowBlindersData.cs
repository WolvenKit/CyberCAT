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
        public bool HasOpenInteraction { get; set; }
        
        [RealName("hasTiltInteraction")]
        public bool HasTiltInteraction { get; set; }
        
        [RealName("hasQuickHack")]
        public bool HasQuickHack { get; set; }

        public WindowBlindersData()
        {
            HasOpenInteraction = true;
            HasQuickHack = true;
        }
    }
}
