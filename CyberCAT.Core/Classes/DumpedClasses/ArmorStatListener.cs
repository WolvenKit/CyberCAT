using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ArmorStatListener")]
    public class ArmorStatListener : GameScriptStatPoolsListener
    {
        [RealName("ownerPuppet")]
        public PlayerPuppet OwnerPuppet { get; set; }
    }
}
