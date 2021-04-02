using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("VisibilityStatListener")]
    public class VisibilityStatListener : GameScriptStatsListener
    {
        [RealName("owner")]
        public GameObject Owner { get; set; }
    }
}
