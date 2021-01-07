using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
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
