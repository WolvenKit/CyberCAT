using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("vehicleGarageComponentVehicleData")]
    public class VehicleGarageComponentVehicleData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("spawnRecordID")]
        public TweakDbId SpawnRecordID { get; set; }
        
        [RealName("entityID")]
        public EntEntityID EntityID { get; set; }
        
        [RealName("vehicleNameNodeRef")]
        public NodeRef VehicleNameNodeRef { get; set; }
    }
}
