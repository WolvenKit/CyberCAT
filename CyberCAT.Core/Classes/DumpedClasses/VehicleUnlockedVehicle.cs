using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("vehicleUnlockedVehicle")]
    public class VehicleUnlockedVehicle : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("vehicleID")]
        public VehicleGarageVehicleID VehicleID { get; set; }
        
        [RealName("health")]
        [RealType("Float")]
        public float Health { get; set; }
    }
}
