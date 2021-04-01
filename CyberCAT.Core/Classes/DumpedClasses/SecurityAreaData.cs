using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SecurityAreaData")]
    public class SecurityAreaData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("securityArea")]
        public SecurityAreaControllerPS SecurityArea { get; set; }
        
        [RealName("securityAreaType")]
        public DumpedEnums.ESecurityAreaType? SecurityAreaType { get; set; }
        
        [RealName("accessLevel")]
        public DumpedEnums.ESecurityAccessLevel? AccessLevel { get; set; }
        
        [RealName("zoneName")]
        public string ZoneName { get; set; }
        
        [RealName("entered")]
        public bool Entered { get; set; }
        
        [RealName("id")]
        public GamePersistentID Id { get; set; }
        
        [RealName("incomingFilters")]
        public DumpedEnums.EFilterType? IncomingFilters { get; set; }
        
        [RealName("outgoingFilters")]
        public DumpedEnums.EFilterType? OutgoingFilters { get; set; }
    }
}
