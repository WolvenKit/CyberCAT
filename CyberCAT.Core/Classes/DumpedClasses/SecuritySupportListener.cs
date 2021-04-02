using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SecuritySupportListener")]
    public class SecuritySupportListener : AIScriptsTargetTrackingListener
    {
        [RealName("npc")]
        public ScriptedPuppet Npc { get; set; }
    }
}
