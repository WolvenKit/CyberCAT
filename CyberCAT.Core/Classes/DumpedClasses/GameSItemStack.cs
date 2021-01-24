using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameSItemStack")]
    public class GameSItemStack : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("itemID")]
        public GameItemID ItemID { get; set; }
        
        [RealName("quantity")]
        public int Quantity { get; set; }
        
        [RealName("powerLevel")]
        public int PowerLevel { get; set; }
        
        [RealName("vendorItemID")]
        public TweakDbId VendorItemID { get; set; }
        
        [RealName("isAvailable")]
        public bool IsAvailable { get; set; }
        
        [RealName("requirement")]
        public GameSItemStackRequirementData Requirement { get; set; }
    }
}
