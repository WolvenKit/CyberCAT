using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("FirstEquipSystem")]
    public class FirstEquipSystem : GameScriptableSystem
    {
        [RealName("equipDataArray")]
        public EFirstEquipData[] EquipDataArray { get; set; }
    }
}
