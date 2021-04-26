using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("CLSWeatherListener")]
    public class CLSWeatherListener : WorldWeatherScriptListener
    {
        [RealName("owner")]
        public CityLightSystem Owner { get; set; }
    }
}
