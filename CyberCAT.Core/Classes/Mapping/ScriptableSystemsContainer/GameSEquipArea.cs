using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("gameSEquipArea")]
    public class GameSEquipArea : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("areaType")]
        public DumpedEnums.gamedataEquipmentArea? AreaType { get; set; }
        
        [RealName("equipSlots")]
        public GameSEquipSlot[] EquipSlots { get; set; }
        
        [RealName("activeIndex")]
        [RealType("Int32")]
        public int ActiveIndex { get; set; }
    }
}
