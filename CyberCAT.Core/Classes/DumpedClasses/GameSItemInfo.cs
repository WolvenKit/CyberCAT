using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameSItemInfo")]
    public class GameSItemInfo : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("itemID")]
        public GameItemID ItemID { get; set; }
        
        [RealName("slotIndex")]
        public int SlotIndex { get; set; }
    }
}
