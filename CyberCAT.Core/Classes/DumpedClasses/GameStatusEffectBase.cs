using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameStatusEffectBase")]
    public class GameStatusEffectBase : IScriptable
    {
        [RealName("statusEffectRecordID")]
        [RealType("TweakDBID")]
        public TweakDbId StatusEffectRecordID { get; set; }
    }
}
