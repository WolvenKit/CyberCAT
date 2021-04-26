using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameeventsApplyStatusEffectEvent")]
    public class GameeventsApplyStatusEffectEvent : GameeventsStatusEffectEvent
    {
        [RealName("instigatorEntityID")]
        public EntEntityID InstigatorEntityID { get; set; }
        
        [RealName("isNewApplication")]
        public bool IsNewApplication { get; set; }
        
        [RealName("isAppliedOnSpawn")]
        public bool IsAppliedOnSpawn { get; set; }
    }
}
