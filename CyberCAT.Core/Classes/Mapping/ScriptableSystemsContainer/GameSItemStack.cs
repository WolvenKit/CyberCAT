using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("gameSItemStack")]
    public class GameSItemStack : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("itemID")]
        public GameItemID ItemID { get; set; }
        
        [RealName("quantity")]
        [RealType("Int32")]
        public int Quantity { get; set; }
        
        [RealName("powerLevel")]
        [RealType("Int32")]
        public int PowerLevel { get; set; }
        
        [RealName("vendorItemID")]
        [RealType("TweakDBID")]
        public ulong VendorItemID { get; set; }
        
        [RealName("isAvailable")]
        [RealType("Bool")]
        public bool IsAvailable { get; set; }
        
        [RealName("requirement")]
        public GameSItemStackRequirementData Requirement { get; set; }
    }
}
