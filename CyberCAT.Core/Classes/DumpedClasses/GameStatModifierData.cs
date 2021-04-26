using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameStatModifierData")]
    public class GameStatModifierData : IScriptable
    {
        [RealName("statType")]
        public DumpedEnums.gamedataStatType? StatType { get; set; }
        
        [RealName("modifierType")]
        public DumpedEnums.gameStatModifierType? ModifierType { get; set; }
    }
}
