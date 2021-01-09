using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("InventoryItemAttachments")]
    public class InventoryItemAttachments : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("SlotID")]
        [RealType("TweakDBID")]
        public TweakDbId SlotID { get; set; }
        
        [RealName("ItemData")]
        public InventoryItemData ItemData { get; set; }
        
        [RealName("SlotName")]
        [RealType("String")]
        public string SlotName { get; set; }
        
        [RealName("SlotType")]
        public DumpedEnums.gameInventoryItemAttachmentType? SlotType { get; set; }
    }
}
