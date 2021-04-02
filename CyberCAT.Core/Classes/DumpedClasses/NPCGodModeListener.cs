using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("NPCGodModeListener")]
    public class NPCGodModeListener : GameScriptStatsListener
    {
        [RealName("owner")]
        public NPCPuppet Owner { get; set; }
    }
}
