using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("EquipmentSystem")]
    public class EquipmentSystem : GameScriptableSystem
    {
        [RealName("ownerData")]
        public Handle<EquipmentSystemPlayerData>[] OwnerData { get; set; }
    }
}
