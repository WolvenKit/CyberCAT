using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("vehicleControllerPS")]
    public class VehicleControllerPS : GameComponentPS
    {
        [RealName("vehicleDoors")]
        [RealType("vehicleVehicleSlotsState", IsStatic = true)]
        public VehicleVehicleSlotsState[] VehicleDoors { get; set; }
        
        [RealName("state")]
        public DumpedEnums.vehicleEState? State { get; set; }
        
        [RealName("lightMode")]
        public DumpedEnums.vehicleELightMode? LightMode { get; set; }
        
        [RealName("isAlarmOn")]
        public bool IsAlarmOn { get; set; }
    }
}
