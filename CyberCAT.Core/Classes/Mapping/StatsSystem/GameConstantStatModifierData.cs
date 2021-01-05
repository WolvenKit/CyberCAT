using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.StatsSystem
{
    [RealName("gameConstantStatModifierData")]
    public class GameConstantStatModifierData : GameStatModifierData
    {
        [RealName("value")]
        [RealType("Float")]
        public float Value { get; set; }
    }
}