using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("UpdateOverheatEvent")]
    public class UpdateOverheatEvent : RedEvent
    {
        [RealName("value")]
        public float Value { get; set; }
    }
}
