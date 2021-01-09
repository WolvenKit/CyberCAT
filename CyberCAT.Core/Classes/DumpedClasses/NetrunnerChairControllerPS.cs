using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("NetrunnerChairControllerPS")]
    public class NetrunnerChairControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("killDelay")]
        [RealType("Float")]
        public float KillDelay { get; set; }
    }
}
