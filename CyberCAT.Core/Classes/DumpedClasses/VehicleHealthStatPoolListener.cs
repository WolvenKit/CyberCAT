using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("VehicleHealthStatPoolListener")]
    public class VehicleHealthStatPoolListener : GameCustomValueStatPoolsListener
    {
        [RealName("owner")]
        public VehicleBaseObject Owner { get; set; }
    }
}
