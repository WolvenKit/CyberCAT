using CyberCAT.Core.Classes.Mapping.Global;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("MarketSystem")]
    public class MarketSystem : GameIMarketSystem
    {
        [RealName("vendors")]
        public Handle<Vendor>[] Vendors { get; set; }
        
        [RealName("vendingMachinesVendors")]
        public Handle<Vendor>[] VendingMachinesVendors { get; set; }
    }
}
