using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AreaTypeTransition")]
    public class AreaTypeTransition : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("transitionTo")]
        public DumpedEnums.ESecurityAreaType? TransitionTo { get; set; }
        
        [RealName("transitionHour")]
        public int TransitionHour { get; set; }
        
        [RealName("transitionMode")]
        public DumpedEnums.ETransitionMode? TransitionMode { get; set; }
        
        [RealName("listenerID")]
        public uint ListenerID { get; set; }
    }
}
