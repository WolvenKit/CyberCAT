using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("NPCDeathListener")]
    public class NPCDeathListener : GameScriptStatPoolsListener
    {
        [RealName("npc")]
        public NPCPuppet Npc { get; set; }
    }
}
