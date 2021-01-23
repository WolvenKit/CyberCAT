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
        public bool ToRebuild { get; set; }
        
        [RealName("ToRebuildItemsWithEquipped")]
        public bool ToRebuildItemsWithEquipped { get; set; }
        
        [RealName("ToRebuildWeapons")]
        public bool ToRebuildWeapons { get; set; }
        
        [RealName("ToRebuildEquipment")]
        public bool ToRebuildEquipment { get; set; }
        
        [RealName("ToRebuildQuickSlots")]
        public bool ToRebuildQuickSlots { get; set; }
        
        [RealName("ToRebuildConsumables")]
        public bool ToRebuildConsumables { get; set; }
        
        [RealName("ActiveWeapon")]
        public GameItemID ActiveWeapon { get; set; }
        
        [RealName("EquipRecords")]
        public Handle<GamedataEquipmentArea_Record>[] EquipRecords { get; set; }
        
        [RealName("ItemIconGender")]
        public DumpedEnums.gameItemIconGender? ItemIconGender { get; set; }
        
        [RealName("WeaponUIBlackboard")]
        public WHandle<GameIBlackboard> WeaponUIBlackboard { get; set; }
        
        [RealName("UIBBEquipmentBlackboard")]
        public WHandle<GameIBlackboard> UIBBEquipmentBlackboard { get; set; }
        
        [RealName("UIBBItemModBlackbord")]
        public WHandle<GameIBlackboard> UIBBItemModBlackbord { get; set; }
        
        [RealName("UIBBEquipment")]
        public Handle<UI_EquipmentDef> UIBBEquipment { get; set; }
        
        [RealName("UIBBItemMod")]
        public Handle<UI_ItemModSystemDef> UIBBItemMod { get; set; }
        
        [RealName("InventoryBBID")]
        public uint InventoryBBID { get; set; }
        
        [RealName("EquipmentBBID")]
        public uint EquipmentBBID { get; set; }
        
        [RealName("SubEquipmentBBID")]
        public uint SubEquipmentBBID { get; set; }
        
        [RealName("ItemModBBID")]
        public uint ItemModBBID { get; set; }
        
        [RealName("BBWeaponList")]
        public uint BBWeaponList { get; set; }
    }
}
