using CyberCAT.Core.Classes.Mapping.Global;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("UIScriptableSystem")]
    public class UIScriptableSystem : GameScriptableSystem
    {
        [RealName("backpackActiveSorting")]
        [RealType("Int32")]
        public int BackpackActiveSorting { get; set; }
        
        [RealName("backpackActiveFilter")]
        [RealType("Int32")]
        public int BackpackActiveFilter { get; set; }
        
        [RealName("isBackpackActiveFilterSaved")]
        [RealType("Bool")]
        public bool IsBackpackActiveFilterSaved { get; set; }
        
        [RealName("vendorPanelPlayerActiveSorting")]
        [RealType("Int32")]
        public int VendorPanelPlayerActiveSorting { get; set; }
        
        [RealName("vendorPanelVendorActiveSorting")]
        [RealType("Int32")]
        public int VendorPanelVendorActiveSorting { get; set; }
        
        [RealName("newItems")]
        public GameItemID[] NewItems { get; set; }
        
        [RealName("inventoryListenerCallback")]
        public Handle<UIScriptableInventoryListenerCallback> InventoryListenerCallback { get; set; }
        
        [RealName("inventoryListener")]
        public Handle<GameInventoryScriptListener> InventoryListener { get; set; }
    }
}
