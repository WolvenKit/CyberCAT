using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DEBUG_DamageInputReceiver")]
    public class DEBUG_DamageInputReceiver : IScriptable
    {
        [RealName("player")]
        public PlayerPuppet Player { get; set; }
    }
}
