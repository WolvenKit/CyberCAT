using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AISpotUsageToken")]
    public class AISpotUsageToken : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("usedSpotId")]
        public WorldGlobalNodeID UsedSpotId { get; set; }
        
        [RealName("spotUserId")]
        public EntEntityID SpotUserId { get; set; }
    }
}
