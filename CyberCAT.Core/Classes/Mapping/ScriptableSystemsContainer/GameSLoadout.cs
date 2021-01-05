using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("gameSLoadout")]
    public class GameSLoadout : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("equipAreas")]
        public GameSEquipArea[] EquipAreas { get; set; }
        
        [RealName("equipmentSets")]
        public GameSEquipmentSet[] EquipmentSets { get; set; }
    }
}
