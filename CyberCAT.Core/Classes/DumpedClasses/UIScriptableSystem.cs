using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("UIScriptableSystem")]
    public class UIScriptableSystem : GameScriptableSystem
    {
        [RealName("backpackActiveSorting")]
        public int BackpackActiveSorting { get; set; }
        
        [RealName("backpackActiveFilter")]
        public int BackpackActiveFilter { get; set; }
        
        [RealName("isBackpackActiveFilterSaved")]
        public bool IsBackpackActiveFilterSaved { get; set; }
        
        [RealName("vendorPanelPlayerActiveSorting")]
        public int VendorPanelPlayerActiveSorting { get; set; }
        
        [RealName("vendorPanelVendorActiveSorting")]
        public int VendorPanelVendorActiveSorting { get; set; }
        
        [RealName("newItems")]
        public GameItemID[] NewItems { get; set; }
        
        [RealName("inventoryListenerCallback")]
        public Handle<UIScriptableInventoryListenerCallback> InventoryListenerCallback { get; set; }
        
        [RealName("inventoryListener")]
        public Handle<GameInventoryScriptListener> InventoryListener { get; set; }
    }
}
