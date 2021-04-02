using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("HealthUpdateEvent")]
    public class HealthUpdateEvent : RedEvent
    {
        [RealName("value")]
        public float Value { get; set; }
        
        [RealName("healthDifference")]
        public float HealthDifference { get; set; }
    }
}
