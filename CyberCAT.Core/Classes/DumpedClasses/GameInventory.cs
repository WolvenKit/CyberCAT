using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameInventory")]
    public class GameInventory : GameComponent
    {
        [RealName("inventoryTag")]
        public DumpedEnums.gameSharedInventoryTag? InventoryTag { get; set; }
        
        [RealName("noInitialization")]
        public bool NoInitialization { get; set; }
        
        [RealName("saveInventory")]
        public bool SaveInventory { get; set; }
    }
}
