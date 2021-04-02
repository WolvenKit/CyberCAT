using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("NPCManager")]
    public class NPCManager : IScriptable
    {
        [RealName("owner")]
        public NPCPuppet Owner { get; set; }
    }
}
