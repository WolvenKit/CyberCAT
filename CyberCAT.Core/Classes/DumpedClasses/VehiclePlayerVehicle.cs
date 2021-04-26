using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("vehiclePlayerVehicle")]
    public class VehiclePlayerVehicle : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("name")]
        public CName Name { get; set; }
        
        [RealName("recordID")]
        public TweakDbId RecordID { get; set; }
        
        [RealName("vehicleType")]
        public DumpedEnums.gamedataVehicleType? VehicleType { get; set; }
        
        [RealName("isUnlocked")]
        public bool IsUnlocked { get; set; }
    }
}
