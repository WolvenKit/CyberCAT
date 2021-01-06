using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("InventoryItemData")]
    public class InventoryItemData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("Empty")]
        [RealType("Bool")]
        public bool Empty { get; set; }
        
        [RealName("ID")]
        public GameItemID ID { get; set; }
        
        [RealName("SlotID")]
        [RealType("TweakDBID")]
        public TweakDbId SlotID { get; set; }
        
        [RealName("Name")]
        [RealType("String")]
        public string Name { get; set; }
        
        [RealName("Quality")]
        [RealType("CName")]
        public string Quality { get; set; }
        
        [RealName("Quantity")]
        [RealType("Int32")]
        public int Quantity { get; set; }
        
        [RealName("Ammo")]
        [RealType("Int32")]
        public int Ammo { get; set; }
        
        [RealName("Shape")]
        public DumpedEnums.gameInventoryItemShape? Shape { get; set; }
        
        [RealName("ItemShape")]
        public DumpedEnums.gameInventoryItemShape? ItemShape { get; set; }
        
        [RealName("IconPath")]
        [RealType("String")]
        public string IconPath { get; set; }
        
        [RealName("CategoryName")]
        [RealType("String")]
        public string CategoryName { get; set; }
        
        [RealName("ItemType")]
        public DumpedEnums.gamedataItemType? ItemType { get; set; }
        
        [RealName("LocalizedItemType")]
        [RealType("String")]
        public string LocalizedItemType { get; set; }
        
        [RealName("Description")]
        [RealType("String")]
        public string Description { get; set; }
        
        [RealName("AdditionalDescription")]
        [RealType("String")]
        public string AdditionalDescription { get; set; }
        
        [RealName("Price")]
        [RealType("Float")]
        public float Price { get; set; }
        
        [RealName("BuyPrice")]
        [RealType("Float")]
        public float BuyPrice { get; set; }
        
        [RealName("UnlockProgress")]
        [RealType("Float")]
        public float UnlockProgress { get; set; }
        
        [RealName("RequiredLevel")]
        [RealType("Int32")]
        public int RequiredLevel { get; set; }
        
        [RealName("ItemLevel")]
        [RealType("Int32")]
        public int ItemLevel { get; set; }
        
        [RealName("DamageType")]
        public DumpedEnums.gamedataDamageType? DamageType { get; set; }
        
        [RealName("EquipmentArea")]
        public DumpedEnums.gamedataEquipmentArea? EquipmentArea { get; set; }
        
        [RealName("ComparedQuality")]
        public DumpedEnums.gamedataQuality? ComparedQuality { get; set; }
        
        [RealName("IsPart")]
        [RealType("Bool")]
        public bool IsPart { get; set; }
        
        [RealName("IsCraftingMaterial")]
        [RealType("Bool")]
        public bool IsCraftingMaterial { get; set; }
        
        [RealName("IsEquipped")]
        [RealType("Bool")]
        public bool IsEquipped { get; set; }
        
        [RealName("IsNew")]
        [RealType("Bool")]
        public bool IsNew { get; set; }
        
        [RealName("IsAvailable")]
        [RealType("Bool")]
        public bool IsAvailable { get; set; }
        
        [RealName("IsVendorItem")]
        [RealType("Bool")]
        public bool IsVendorItem { get; set; }
        
        [RealName("IsBroken")]
        [RealType("Bool")]
        public bool IsBroken { get; set; }
        
        [RealName("SlotIndex")]
        [RealType("Int32")]
        public int SlotIndex { get; set; }
        
        [RealName("PositionInBackpack")]
        [RealType("Uint32")]
        public uint PositionInBackpack { get; set; }
        
        [RealName("IconGender")]
        public DumpedEnums.gameItemIconGender? IconGender { get; set; }
        
        [RealName("HasPlayerSmartGunLink")]
        [RealType("Bool")]
        public bool HasPlayerSmartGunLink { get; set; }
        
        [RealName("PlayerLevel")]
        [RealType("Int32")]
        public int PlayerLevel { get; set; }
        
        [RealName("PlayerStrenght")]
        [RealType("Int32")]
        public int PlayerStrenght { get; set; }
        
        [RealName("PlayerReflexes")]
        [RealType("Int32")]
        public int PlayerReflexes { get; set; }
        
        [RealName("PlayerStreetCred")]
        [RealType("Int32")]
        public int PlayerStreetCred { get; set; }
        
        [RealName("IsRequirementMet")]
        [RealType("Bool")]
        public bool IsRequirementMet { get; set; }
        
        [RealName("IsEquippable")]
        [RealType("Bool")]
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
        [RealType("TweakDBID")]
        public TweakDbId[] PlacementSlots { get; set; }
        
        [RealName("PrimaryStats")]
        public GameStatViewData[] PrimaryStats { get; set; }
        
        [RealName("SecondaryStats")]
        public GameStatViewData[] SecondaryStats { get; set; }
    }
}
