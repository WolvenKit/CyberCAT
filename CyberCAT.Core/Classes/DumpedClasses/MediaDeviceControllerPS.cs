using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("MediaDeviceControllerPS")]
    public class MediaDeviceControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("previousStation")]
        [RealType("Int32")]
        public int PreviousStation { get; set; }
        
        [RealName("activeChannelName")]
        [RealType("String")]
        public string ActiveChannelName { get; set; }
        
        [RealName("dataInitialized")]
        [RealType("Bool")]
        public bool DataInitialized { get; set; }
        
        [RealName("amountOfStations")]
        [RealType("Int32")]
        public int AmountOfStations { get; set; }
        
        [RealName("activeStation")]
        [RealType("Int32")]
        public int ActiveStation { get; set; }
    }
}
