using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("VirtualSystemPS")]
    public class VirtualSystemPS : MasterControllerPS
    {
        [RealName("owner")]
        public MasterControllerPS Owner { get; set; }
        
        [RealName("slaves")]
        public Handle<GameDeviceComponentPS>[] Slaves { get; set; }
        
        [RealName("slavesCached")]
        public bool SlavesCached { get; set; }
    }
}
