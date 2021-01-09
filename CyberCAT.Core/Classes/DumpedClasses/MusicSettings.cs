using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("MusicSettings")]
    public class MusicSettings : IScriptable
    {
        [RealName("statusEffect")]
        public DumpedEnums.ESoundStatusEffects? StatusEffect { get; set; }
    }
}
