using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("vehicleGarageVehicleID")]
    public class VehicleGarageVehicleID : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("recordID")]
        public TweakDbId RecordID { get; set; }
        
        [RealName("name")]
        public CName Name { get; set; }
    }
}
