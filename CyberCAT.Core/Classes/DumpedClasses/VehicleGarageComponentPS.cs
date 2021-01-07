using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("vehicleGarageComponentPS")]
    public class VehicleGarageComponentPS : GameComponentPS
    {
        [RealName("spawnedVehiclesData")]
        public VehicleGarageComponentVehicleData[] SpawnedVehiclesData { get; set; }
        
        [RealName("unlockedVehicles")]
        public VehicleGarageVehicleID[] UnlockedVehicles { get; set; }
        
        [RealName("unlockedVehicleArray")]
        public VehicleUnlockedVehicle[] UnlockedVehicleArray { get; set; }
        
        [RealName("activeVehicles")]
        [RealType("vehicleGarageVehicleID", IsStatic = true)]
        public VehicleGarageVehicleID[] ActiveVehicles { get; set; }
        
        [RealName("mountedVehicleData")]
        public VehicleGarageComponentVehicleData MountedVehicleData { get; set; }
        
        [RealName("mountedVehicleStolen")]
        [RealType("Bool")]
        public bool MountedVehicleStolen { get; set; }
    }
}
