using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("InventoryDataManagerV2")]
    public class InventoryDataManagerV2 : IScriptable
    {
        [RealName("TransactionSystem")]
        public Handle<GameTransactionSystem> TransactionSystem { get; set; }
        
        [RealName("EquipmentSystem")]
        public Handle<EquipmentSystem> EquipmentSystem { get; set; }
        
        [RealName("StatsSystem")]
        public Handle<GameStatsSystem> StatsSystem { get; set; }
        
        [RealName("ItemModificationSystem")]
        public Handle<ItemModificationSystem> ItemModificationSystem { get; set; }
        
        [RealName("LocMgr")]
        public Handle<UILocalizationMap> LocMgr { get; set; }
        
        [RealName("InventoryItemsData")]
        public InventoryItemData[] InventoryItemsData { get; set; }
        
        [RealName("InventoryItemsDataWithoutEquipment")]
        public InventoryItemData[] InventoryItemsDataWithoutEquipment { get; set; }
        
        [RealName("EquipmentItemsData")]
        public InventoryItemData[] EquipmentItemsData { get; set; }
        
        [RealName("WeaponItemsData")]
        public InventoryItemData[] WeaponItemsData { get; set; }
        
        [RealName("QuickSlotsData")]
        public InventoryItemData[] QuickSlotsData { get; set; }
        
        [RealName("ConsumablesSlotsData")]
        public InventoryItemData[] ConsumablesSlotsData { get; set; }
        
        [RealName("ToRebuild")]
        [RealType("Bool")]
        public bool ToRebuild { get; set; }
        
        [RealName("ToRebuildItemsWithEquipped")]
        [RealType("Bool")]
        public bool ToRebuildItemsWithEquipped { get; set; }
        
        [RealName("ToRebuildWeapons")]
        [RealType("Bool")]
        public bool ToRebuildWeapons { get; set; }
        
        [RealName("ToRebuildEquipment")]
        [RealType("Bool")]
        public bool ToRebuildEquipment { get; set; }
        
        [RealName("ToRebuildQuickSlots")]
        [RealType("Bool")]
        public bool ToRebuildQuickSlots { get; set; }
        
        [RealName("ToRebuildConsumables")]
        [RealType("Bool")]
        public bool ToRebuildConsumables { get; set; }
        
        [RealName("ActiveWeapon")]
        public GameItemID ActiveWeapon { get; set; }
        
        [RealName("EquipRecords")]
        public Handle<GamedataEquipmentArea_Record>[] EquipRecords { get; set; }
        
        [RealName("ItemIconGender")]
        public DumpedEnums.gameItemIconGender? ItemIconGender { get; set; }
        
        [RealName("WeaponUIBlackboard")]
        public Handle<GameIBlackboard> WeaponUIBlackboard { get; set; }
        
        [RealName("UIBBEquipmentBlackboard")]
        public Handle<GameIBlackboard> UIBBEquipmentBlackboard { get; set; }
        
        [RealName("UIBBItemModBlackbord")]
        public Handle<GameIBlackboard> UIBBItemModBlackbord { get; set; }
        
        [RealName("UIBBEquipment")]
        public Handle<UI_EquipmentDef> UIBBEquipment { get; set; }
        
        [RealName("UIBBItemMod")]
        public Handle<UI_ItemModSystemDef> UIBBItemMod { get; set; }
        
        [RealName("InventoryBBID")]
        [RealType("Uint32")]
        public uint InventoryBBID { get; set; }
        
        [RealName("EquipmentBBID")]
        [RealType("Uint32")]
        public uint EquipmentBBID { get; set; }
        
        [RealName("SubEquipmentBBID")]
        [RealType("Uint32")]
        public uint SubEquipmentBBID { get; set; }
        
        [RealName("ItemModBBID")]
        [RealType("Uint32")]
        public uint ItemModBBID { get; set; }
        
        [RealName("BBWeaponList")]
        [RealType("Uint32")]
        public uint BBWeaponList { get; set; }
    }
}
