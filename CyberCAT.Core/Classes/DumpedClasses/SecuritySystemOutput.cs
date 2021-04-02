using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SecuritySystemOutput")]
    public class SecuritySystemOutput : ActionBool
    {
        [RealName("currentSecurityState")]
        public DumpedEnums.ESecuritySystemState? CurrentSecurityState { get; set; }
        
        [RealName("breachOrigin")]
        public DumpedEnums.EBreachOrigin? BreachOrigin { get; set; }
        
        [RealName("originalInputEvent")]
        public Handle<SecuritySystemInput> OriginalInputEvent { get; set; }
        
        [RealName("securityStateChanged")]
        public bool SecurityStateChanged { get; set; }
    }
}
