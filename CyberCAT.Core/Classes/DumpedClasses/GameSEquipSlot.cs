using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameSEquipSlot")]
    public class GameSEquipSlot : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("itemID")]
        public GameItemID ItemID { get; set; }
        
        [RealName("isLocked")]
        [RealType("Bool")]
        public bool IsLocked { get; set; }
    }
}
