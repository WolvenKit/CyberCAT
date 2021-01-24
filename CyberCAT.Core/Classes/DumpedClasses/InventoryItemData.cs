using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("InventoryItemData")]
    public class InventoryItemData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("Empty")]
        public bool Empty { get; set; }
        
        [RealName("ID")]
        public GameItemID ID { get; set; }
        
        [RealName("SlotID")]
        public TweakDbId SlotID { get; set; }
        
        [RealName("Name")]
        public string Name { get; set; }
        
        [RealName("Quality")]
        public CName Quality { get; set; }
        
        [RealName("Quantity")]
        public int Quantity { get; set; }
        
        [RealName("Ammo")]
        public int Ammo { get; set; }
        
        [RealName("Shape")]
        public DumpedEnums.gameInventoryItemShape? Shape { get; set; }
        
        [RealName("ItemShape")]
        public DumpedEnums.gameInventoryItemShape? ItemShape { get; set; }
        
        [RealName("IconPath")]
        public string IconPath { get; set; }
        
        [RealName("CategoryName")]
        public string CategoryName { get; set; }
        
        [RealName("ItemType")]
        public DumpedEnums.gamedataItemType? ItemType { get; set; }
        
        [RealName("LocalizedItemType")]
        public string LocalizedItemType { get; set; }
        
        [RealName("Description")]
        public string Description { get; set; }
        
        [RealName("AdditionalDescription")]
        public string AdditionalDescription { get; set; }
        
        [RealName("Price")]
        public float Price { get; set; }
        
        [RealName("BuyPrice")]
        public float BuyPrice { get; set; }
        
        [RealName("UnlockProgress")]
        public float UnlockProgress { get; set; }
        
        [RealName("RequiredLevel")]
        public int RequiredLevel { get; set; }
        
        [RealName("ItemLevel")]
        public int ItemLevel { get; set; }
        
        [RealName("DamageType")]
        public DumpedEnums.gamedataDamageType? DamageType { get; set; }
        
        [RealName("EquipmentArea")]
        public DumpedEnums.gamedataEquipmentArea? EquipmentArea { get; set; }
        
        [RealName("ComparedQuality")]
        public DumpedEnums.gamedataQuality? ComparedQuality { get; set; }
        
        [RealName("IsPart")]
        public bool IsPart { get; set; }
        
        [RealName("IsCraftingMaterial")]
        public bool IsCraftingMaterial { get; set; }
        
        [RealName("IsEquipped")]
        public bool IsEquipped { get; set; }
        
        [RealName("IsNew")]
        public bool IsNew { get; set; }
        
        [RealName("IsAvailable")]
        public bool IsAvailable { get; set; }
        
        [RealName("IsVendorItem")]
        public bool IsVendorItem { get; set; }
        
        [RealName("IsBroken")]
        public bool IsBroken { get; set; }
        
        [RealName("SlotIndex")]
        public int SlotIndex { get; set; }
        
        [RealName("PositionInBackpack")]
        public uint PositionInBackpack { get; set; }
        
        [RealName("IconGender")]
        public DumpedEnums.gameItemIconGender? IconGender { get; set; }
        
        [RealName("HasPlayerSmartGunLink")]
        public bool HasPlayerSmartGunLink { get; set; }
        
        [RealName("PlayerLevel")]
        public int PlayerLevel { get; set; }
        
        [RealName("PlayerStrenght")]
        public int PlayerStrenght { get; set; }
        
        [RealName("PlayerReflexes")]
        public int PlayerReflexes { get; set; }
        
        [RealName("PlayerStreetCred")]
        public int PlayerStreetCred { get; set; }
        
        [RealName("IsRequirementMet")]
        public bool IsRequirementMet { get; set; }
        
        [RealName("IsEquippable")]
        public bool IsEquippable { get; set; }
        
        [RealName("Requirement")]
        public GameSItemStackRequirementData Requirement { get; set; }
        
        [RealName("EquipRequirement")]
        public GameSItemStackRequirementData EquipRequirement { get; set; }
        
        [RealName("LootItemType")]
        public DumpedEnums.gameLootItemType? LootItemType { get; set; }
        
        [RealName("Attachments")]
        public InventoryItemAttachments[] Attachments { get; set; }
        
        [RealName("Abilities")]
        public GameInventoryItemAbility[] Abilities { get; set; }
        
        [RealName("PlacementSlots")]
        public TweakDbId[] PlacementSlots { get; set; }
        
        [RealName("PrimaryStats")]
        public GameStatViewData[] PrimaryStats { get; set; }
        
        [RealName("SecondaryStats")]
        public GameStatViewData[] SecondaryStats { get; set; }
    }
}
