using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("Agent")]
    public class Agent : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("link")]
        public DeviceLink Link { get; set; }
        
        [RealName("reprimands")]
        public ReprimandData[] Reprimands { get; set; }
        
        [RealName("supportingAgents")]
        public GamePersistentID[] SupportingAgents { get; set; }
        
        [RealName("areas")]
        public DeviceLink[] Areas { get; set; }
        
        [RealName("incomingFilter")]
        public DumpedEnums.EFilterType? IncomingFilter { get; set; }
        
        [RealName("cachedDelayDuration")]
        public float CachedDelayDuration { get; set; }
    }
}
