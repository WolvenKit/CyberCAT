using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("QuickSlotCommand")]
    public class QuickSlotCommand : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("ActionType")]
        public DumpedEnums.QuickSlotActionType? ActionType { get; set; }
        
        [RealName("IsSlotUnlocked")]
        public bool IsSlotUnlocked { get; set; }
        
        [RealName("IsLocked")]
        public bool IsLocked { get; set; }
        
        [RealName("AtlasPath")]
        public CName AtlasPath { get; set; }
        
        [RealName("IconName")]
        public CName IconName { get; set; }
        
        [RealName("MaxTier")]
        public int MaxTier { get; set; }
        
        [RealName("VehicleState")]
        public int VehicleState { get; set; }
        
        [RealName("ItemId")]
        public GameItemID ItemId { get; set; }
        
        [RealName("Title")]
        public string Title { get; set; }
        
        [RealName("Type")]
        public string Type { get; set; }
        
        [RealName("Description")]
        public string Description { get; set; }
        
        [RealName("IsEquipped")]
        public bool IsEquipped { get; set; }
        
        [RealName("intData")]
        public int IntData { get; set; }
        
        [RealName("playerVehicleData")]
        public VehiclePlayerVehicle PlayerVehicleData { get; set; }
        
        [RealName("itemType")]
        public DumpedEnums.QuickSlotItemType? ItemType { get; set; }
        
        [RealName("equipType")]
        public DumpedEnums.gamedataEquipmentArea? EquipType { get; set; }
        
        [RealName("slotIndex")]
        public int SlotIndex { get; set; }
        
        [RealName("interactiveAction")]
        public Handle<GamedeviceAction> InteractiveAction { get; set; }
        
        [RealName("interactiveActionOwner")]
        public EntEntityID InteractiveActionOwner { get; set; }
    }
}
