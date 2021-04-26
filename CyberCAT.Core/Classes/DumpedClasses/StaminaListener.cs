using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("StaminaListener")]
    public class StaminaListener : GameCustomValueStatPoolsListener
    {
        [RealName("player")]
        public PlayerPuppet Player { get; set; }
        
        [RealName("psmAdded")]
        public bool PsmAdded { get; set; }
    }
}
