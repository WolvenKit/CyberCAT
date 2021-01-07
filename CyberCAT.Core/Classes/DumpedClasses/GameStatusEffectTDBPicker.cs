using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameStatusEffectTDBPicker")]
    public class GameStatusEffectTDBPicker : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("statusEffect")]
        [RealType("TweakDBID")]
        public TweakDbId StatusEffect { get; set; }
    }
}
