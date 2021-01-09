using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("EventsFilters")]
    public class EventsFilters : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("incomingEventsFilter")]
        public DumpedEnums.EFilterType? IncomingEventsFilter { get; set; }
        
        [RealName("outgoingEventsFilter")]
        public DumpedEnums.EFilterType? OutgoingEventsFilter { get; set; }
    }
}
