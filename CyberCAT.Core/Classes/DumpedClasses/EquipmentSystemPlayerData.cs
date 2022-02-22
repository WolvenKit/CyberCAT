using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("EquipmentSystemPlayerData")]
    public class EquipmentSystemPlayerData : IScriptable
    {
        [RealName("owner")]
        public ScriptedPuppet Owner { get; set; }
        
        [RealName("ownerID")]
        public EntEntityID OwnerID { get; set; }
        
        [RealName("equipment")]
        public GameSLoadout Equipment { get; set; }
        
        [RealName("lastUsedStruct")]
        public GameSLastUsedWeapon LastUsedStruct { get; set; }
        
        [RealName("slotActiveItemsInHands")]
        public GameSSlotActiveItems SlotActiveItemsInHands { get; set; }
        
        [RealName("hiddenItems")]
        public GameItemID[] HiddenItems { get; set; }
        
        [RealName("clothingSlotsInfo")]
        public GameSSlotInfo[] ClothingSlotsInfo { get; set; }

        [RealName("clothingVisualsInfo")]
        public SSlotVisualInfo[] ClothingVisualsInfo { get; set; }

        [RealName("isPartialVisualTagActive")]
        public bool IsPartialVisualTagActive { get; set; }
        
        [RealName("visualTagProcessingInfo")]
        public GameSVisualTagProcessing[] VisualTagProcessingInfo { get; set; }
        
        [RealName("eventsSent")]
        public int EventsSent { get; set; }
        
        [RealName("hotkeys")]
        public Handle<Hotkey>[] Hotkeys { get; set; }
        
        [RealName("inventoryManager")]
        public Handle<InventoryDataManagerV2> InventoryManager { get; set; }
    }
}
