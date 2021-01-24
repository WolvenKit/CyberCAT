using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("NetrunnerChairControllerPS")]
    public class NetrunnerChairControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("killDelay")]
        public float KillDelay { get; set; }
    }
}
