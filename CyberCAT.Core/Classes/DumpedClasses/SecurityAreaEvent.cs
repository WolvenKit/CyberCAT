using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SecurityAreaEvent")]
    public class SecurityAreaEvent : ActionBool
    {
        [RealName("securityAreaData")]
        public SecurityAreaData SecurityAreaData { get; set; }
        
        [RealName("whoBreached")]
        public GameObject WhoBreached { get; set; }
    }
}
