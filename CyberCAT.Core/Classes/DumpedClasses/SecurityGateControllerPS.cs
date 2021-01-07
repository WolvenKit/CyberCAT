using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SecurityGateControllerPS")]
    public class SecurityGateControllerPS : MasterControllerPS
    {
        [RealName("securityGateDetectionProperties")]
        public SecurityGateDetectionProperties SecurityGateDetectionProperties { get; set; }
        
        [RealName("securityGateResponseProperties")]
        public SecurityGateResponseProperties SecurityGateResponseProperties { get; set; }
        
        [RealName("securityGateStatus")]
        public DumpedEnums.ESecurityGateStatus? SecurityGateStatus { get; set; }
        
        [RealName("trespassersDataList")]
        public TrespasserEntry[] TrespassersDataList { get; set; }
    }
}
