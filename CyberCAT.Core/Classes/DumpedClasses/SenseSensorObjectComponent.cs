using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("senseSensorObjectComponent")]
    public class SenseSensorObjectComponent : EntIPlacedComponent
    {
        [RealName("isEnabled")]
        public bool IsEnabled { get; set; }
        
        [RealName("sensorObject")]
        public Handle<SenseSensorObject> SensorObject { get; set; }
    }
}
