using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("CityLightSystem")]
    public class CityLightSystem : GameScriptableSystem
    {
        [RealName("timeSystemCallbacks")]
        public Handle<TimetableCallbackData>[] TimeSystemCallbacks { get; set; }
        
        [RealName("fuses")]
        public FuseData[] Fuses { get; set; }
        
        [RealName("state")]
        public DumpedEnums.ECLSForcedState? State { get; set; }
        
        [RealName("forcedStateSource")]
        [RealType("CName")]
        public string ForcedStateSource { get; set; }
        
        [RealName("forcedStatesStack")]
        public ForcedStateData[] ForcedStatesStack { get; set; }
        
        [RealName("weatherListener")]
        public Handle<CLSWeatherListener> WeatherListener { get; set; }
        
        [RealName("turnOffLisenerID")]
        [RealType("CName")]
        public string TurnOffLisenerID { get; set; }
        
        [RealName("turnOnLisenerID")]
        [RealType("CName")]
        public string TurnOnLisenerID { get; set; }
        
        [RealName("resetLisenerID")]
        [RealType("CName")]
        public string ResetLisenerID { get; set; }
        
        [RealName("weatherCallbackId")]
        [RealType("Uint32")]
        public uint WeatherCallbackId { get; set; }
    }
}
