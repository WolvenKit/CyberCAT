using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AutoRevealStatListener")]
    public class AutoRevealStatListener : GameScriptStatsListener
    {
        [RealName("owner")]
        public GameObject Owner { get; set; }
    }
}
