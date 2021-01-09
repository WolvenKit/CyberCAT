using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameConstantStatModifierData")]
    public class GameConstantStatModifierData : GameStatModifierData
    {
        [RealName("value")]
        [RealType("Float")]
        public float Value { get; set; }
    }
}
