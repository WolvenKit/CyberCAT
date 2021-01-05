using CyberCAT.Core.Classes.Mapping.Global;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("EquipmentSystem")]
    public class EquipmentSystem : GameScriptableSystem
    {
        [RealName("ownerData")]
        public Handle<EquipmentSystemPlayerData>[] OwnerData { get; set; }
    }
}
