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
        public CName ForcedStateSource { get; set; }
        
        [RealName("forcedStatesStack")]
        public ForcedStateData[] ForcedStatesStack { get; set; }
        
        [RealName("weatherListener")]
        public Handle<CLSWeatherListener> WeatherListener { get; set; }
        
        [RealName("turnOffLisenerID")]
        public CName TurnOffLisenerID { get; set; }
        
        [RealName("turnOnLisenerID")]
        public CName TurnOnLisenerID { get; set; }
        
        [RealName("resetLisenerID")]
        public CName ResetLisenerID { get; set; }
        
        [RealName("weatherCallbackId")]
        public uint WeatherCallbackId { get; set; }
    }
}
