using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameSSlotInfo")]
    public class GameSSlotInfo : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("areaType")]
        public DumpedEnums.gamedataEquipmentArea? AreaType { get; set; }
        
        [RealName("equipSlot")]
        public TweakDbId EquipSlot { get; set; }
        
        [RealName("visualTag")]
        public CName VisualTag { get; set; }
    }
}
