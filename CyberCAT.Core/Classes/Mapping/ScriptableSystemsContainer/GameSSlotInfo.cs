using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("gameSSlotInfo")]
    public class GameSSlotInfo : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("areaType")]
        public DumpedEnums.gamedataEquipmentArea? AreaType { get; set; }
        
        [RealName("equipSlot")]
        [RealType("TweakDBID")]
        public TweakDbId EquipSlot { get; set; }
        
        [RealName("visualTag")]
        [RealType("CName")]
        public string VisualTag { get; set; }
    }
}
