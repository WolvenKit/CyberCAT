using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SecondHeartStatListener")]
    public class SecondHeartStatListener : GameScriptStatsListener
    {
        [RealName("player")]
        public PlayerPuppet Player { get; set; }
    }
}
