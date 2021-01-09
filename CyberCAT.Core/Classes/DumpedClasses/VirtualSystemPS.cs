using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("VirtualSystemPS")]
    public class VirtualSystemPS : MasterControllerPS
    {
        [RealName("slaves")]
        public Handle<GameDeviceComponentPS>[] Slaves { get; set; }
        
        [RealName("slavesCached")]
        [RealType("Bool")]
        public bool SlavesCached { get; set; }
    }
}
