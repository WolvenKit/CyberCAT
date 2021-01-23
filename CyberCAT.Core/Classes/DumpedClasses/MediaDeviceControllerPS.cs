using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("MediaDeviceControllerPS")]
    public class MediaDeviceControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("previousStation")]
        public int PreviousStation { get; set; }
        
        [RealName("activeChannelName")]
        public string ActiveChannelName { get; set; }
        
        [RealName("dataInitialized")]
        public bool DataInitialized { get; set; }
        
        [RealName("amountOfStations")]
        public int AmountOfStations { get; set; }
        
        [RealName("activeStation")]
        public int ActiveStation { get; set; }
    }
}
