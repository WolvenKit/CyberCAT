using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SecurityGateLockControllerPS")]
    public class SecurityGateLockControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("tresspasserList")]
        public TrespasserEntry[] TresspasserList { get; set; }
        
        [RealName("entranceToken")]
        public EntEntityID EntranceToken { get; set; }
        
        [RealName("isLeaving")]
        public bool IsLeaving { get; set; }
        
        [RealName("isLocked")]
        public bool IsLocked { get; set; }
    }
}
