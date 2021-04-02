using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DamageHistoryEntry")]
    public class DamageHistoryEntry : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("hitEvent")]
        public Handle<GameeventsHitEvent> HitEvent { get; set; }
        
        [RealName("totalDamageReceived")]
        public float TotalDamageReceived { get; set; }
        
        [RealName("frameReceived")]
        public ulong FrameReceived { get; set; }
        
        [RealName("timestamp")]
        public float Timestamp { get; set; }
        
        [RealName("healthAtTheTime")]
        public float HealthAtTheTime { get; set; }
        
        [RealName("source")]
        public GameObject Source { get; set; }
        
        [RealName("target")]
        public GameObject Target { get; set; }
    }
}
