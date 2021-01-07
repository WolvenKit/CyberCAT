using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("CraftingSystem")]
    public class CraftingSystem : GameScriptableSystem
    {
        [RealName("lastActionStatus")]
        [RealType("Bool")]
        public bool LastActionStatus { get; set; }
        
        [RealName("playerCraftBook")]
        public Handle<CraftBook> PlayerCraftBook { get; set; }
        
        [RealName("callback")]
        public Handle<CraftingSystemInventoryCallback> Callback { get; set; }
        
        [RealName("inventoryListener")]
        public Handle<GameInventoryScriptListener> InventoryListener { get; set; }
        
        [RealName("itemIconGender")]
        public DumpedEnums.gameItemIconGender? ItemIconGender { get; set; }
    }
}
