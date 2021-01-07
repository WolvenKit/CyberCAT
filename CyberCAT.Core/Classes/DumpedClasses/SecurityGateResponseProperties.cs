using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SecurityGateResponseProperties")]
    public class SecurityGateResponseProperties : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("securityGateResponseType")]
        public DumpedEnums.ESecurityGateResponseType? SecurityGateResponseType { get; set; }
        
        [RealName("securityLevelAccessGranted")]
        public DumpedEnums.ESecurityAccessLevel? SecurityLevelAccessGranted { get; set; }
    }
}
