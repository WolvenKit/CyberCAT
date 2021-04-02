using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AITargetTrackerComponent")]
    public class AITargetTrackerComponent : EntIComponent
    {
        [RealName("TriggersCombat")]
        public bool TriggersCombat { get; set; }
    }
}
