using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameStatusEffectTDBPicker")]
    public class GameStatusEffectTDBPicker : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("statusEffect")]
        public TweakDbId StatusEffect { get; set; }
    }
}
