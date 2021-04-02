using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("CombatHUDManager")]
    public class CombatHUDManager : GameScriptableComponent
    {
        [RealName("isRunning")]
        public bool IsRunning { get; set; }
        
        [RealName("targets")]
        public CombatTarget[] Targets { get; set; }
        
        [RealName("interval")]
        public float Interval { get; set; }
        
        [RealName("timeSinceLastUpdate")]
        public float TimeSinceLastUpdate { get; set; }
    }
}
