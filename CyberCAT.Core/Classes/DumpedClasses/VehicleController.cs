using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("vehicleController")]
    public class VehicleController : GameComponent
    {
        [RealName("alarmCurve")]
        public CName AlarmCurve { get; set; }
        
        [RealName("alarmTime")]
        public float AlarmTime { get; set; }
    }
}
