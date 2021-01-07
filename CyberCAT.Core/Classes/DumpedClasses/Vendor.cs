using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("Vendor")]
    public class Vendor : IScriptable
    {
        [RealName("gameInstance")]
        public ScriptGameInstance GameInstance { get; set; }
        
        [RealName("tweakID")]
        [RealType("TweakDBID")]
        public TweakDbId TweakID { get; set; }
        
        [RealName("lastInteractionTime")]
        [RealType("Float")]
        public float LastInteractionTime { get; set; }
        
        [RealName("stock")]
        public GameSItemStack[] Stock { get; set; }
        
        [RealName("priceMultiplier")]
        [RealType("Float")]
        public float PriceMultiplier { get; set; }
        
        [RealName("vendorPersistentID")]
        public GamePersistentID VendorPersistentID { get; set; }
        
        [RealName("stockInit")]
        [RealType("Bool")]
        public bool StockInit { get; set; }
        
        [RealName("inventoryInit")]
        [RealType("Bool")]
        public bool InventoryInit { get; set; }
        
        [RealName("inventoryReinitWithPlayerStats")]
        [RealType("Bool")]
        public bool InventoryReinitWithPlayerStats { get; set; }

        public Vendor()
        {
            PriceMultiplier = 1F;
        }
    }
}
