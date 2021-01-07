using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("vehicleVehicleSlotsState")]
    public class VehicleVehicleSlotsState : ISerializable
    {
        [RealName("vehicleDoorState")]
        public DumpedEnums.vehicleVehicleDoorState? VehicleDoorState { get; set; }
        
        [RealName("vehicleWindowState")]
        public DumpedEnums.vehicleEVehicleWindowState? VehicleWindowState { get; set; }
        
        [RealName("vehicleInteractionState")]
        public DumpedEnums.vehicleVehicleDoorInteractionState? VehicleInteractionState { get; set; }
    }
}
