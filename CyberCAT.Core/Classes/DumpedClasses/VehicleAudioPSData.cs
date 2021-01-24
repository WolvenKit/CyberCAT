using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("vehicleAudioPSData")]
    public class VehicleAudioPSData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("activeRadioStation")]
        public CName ActiveRadioStation { get; set; }
        
        [RealName("acousticIsolationFactor")]
        public float AcousticIsolationFactor { get; set; }
        
        [RealName("isPlayerVehicleSummoned")]
        public bool IsPlayerVehicleSummoned { get; set; }
    }
}
