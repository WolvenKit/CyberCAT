using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("MemoryListener")]
    public class MemoryListener : GameCustomValueStatPoolsListener
    {
        [RealName("player")]
        public PlayerPuppet Player { get; set; }
    }
}
