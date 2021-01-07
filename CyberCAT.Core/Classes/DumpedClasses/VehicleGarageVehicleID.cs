using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("vehicleGarageVehicleID")]
    public class VehicleGarageVehicleID : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("recordID")]
        [RealType("TweakDBID")]
        public TweakDbId RecordID { get; set; }
        
        [RealName("name")]
        [RealType("CName")]
        public string Name { get; set; }
    }
}
