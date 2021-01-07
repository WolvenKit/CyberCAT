using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("vehicleAudioPSData")]
    public class VehicleAudioPSData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("activeRadioStation")]
        [RealType("CName")]
        public string ActiveRadioStation { get; set; }
        
        [RealName("acousticIsolationFactor")]
        [RealType("Float")]
        public float AcousticIsolationFactor { get; set; }
        
        [RealName("isPlayerVehicleSummoned")]
        [RealType("Bool")]
        public bool IsPlayerVehicleSummoned { get; set; }
    }
}
