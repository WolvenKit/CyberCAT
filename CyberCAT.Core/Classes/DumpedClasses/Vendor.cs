using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("Vendor")]
    public class Vendor : IScriptable
    {
        [RealName("gameInstance")]
        public ScriptGameInstance GameInstance { get; set; }
        
        [RealName("vendorObject")]
        public GameObject VendorObject { get; set; }
        
        [RealName("tweakID")]
        public TweakDbId TweakID { get; set; }
        
        [RealName("lastInteractionTime")]
        public float LastInteractionTime { get; set; }
        
        [RealName("stock")]
        public GameSItemStack[] Stock { get; set; }
        
        [RealName("priceMultiplier")]
        public float PriceMultiplier { get; set; }
        
        [RealName("vendorPersistentID")]
        public GamePersistentID VendorPersistentID { get; set; }
        
        [RealName("stockInit")]
        public bool StockInit { get; set; }
        
        [RealName("inventoryInit")]
        public bool InventoryInit { get; set; }
        
        [RealName("inventoryReinitWithPlayerStats")]
        public bool InventoryReinitWithPlayerStats { get; set; }
        
        [RealName("vendorRecord")]
        public GamedataVendor_Record VendorRecord { get; set; }

        public Vendor()
        {
            PriceMultiplier = 1F;
        }
    }
}
