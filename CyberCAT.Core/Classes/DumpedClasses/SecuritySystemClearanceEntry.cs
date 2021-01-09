using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SecuritySystemClearanceEntry")]
    public class SecuritySystemClearanceEntry : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("user")]
        public EntEntityID User { get; set; }
        
        [RealName("level")]
        public DumpedEnums.ESecurityAccessLevel? Level { get; set; }
    }
}
