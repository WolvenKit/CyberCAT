using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AIHumanComponentPS")]
    public class AIHumanComponentPS : AICommandQueuePS
    {
        [RealName("spotUsageToken")]
        public AISpotUsageToken SpotUsageToken { get; set; }
    }
}
