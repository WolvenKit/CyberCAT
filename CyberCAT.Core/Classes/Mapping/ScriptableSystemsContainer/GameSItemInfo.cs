using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("gameSItemInfo")]
    public class GameSItemInfo : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("itemID")]
        public GameItemID ItemID { get; set; }
        
        [RealName("slotIndex")]
        [RealType("Int32")]
        public int SlotIndex { get; set; }
    }
}
