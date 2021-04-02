using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("HitHistoryItem")]
    public class HitHistoryItem : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("instigator")]
        public GameObject Instigator { get; set; }
        
        [RealName("hitTime")]
        public float HitTime { get; set; }
        
        [RealName("isMelee")]
        public bool IsMelee { get; set; }
    }
}
