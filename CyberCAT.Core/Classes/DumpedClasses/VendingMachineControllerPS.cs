using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("VendingMachineControllerPS")]
    public class VendingMachineControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("vendingMachineSetup")]
        public VendingMachineSetup VendingMachineSetup { get; set; }
        
        [RealName("vendingMachineSFX")]
        public VendingMachineSFX VendingMachineSFX { get; set; }
        
        [RealName("soldOutProbability")]
        public float SoldOutProbability { get; set; }
        
        [RealName("isReady")]
        public bool IsReady { get; set; }
        
        [RealName("isSoldOut")]
        public bool IsSoldOut { get; set; }
        
        [RealName("hackCount")]
        public int HackCount { get; set; }
        
        [RealName("shopStock")]
        public GameSItemStack[] ShopStock { get; set; }
        
        [RealName("shopStockInit")]
        public bool ShopStockInit { get; set; }
    }
}
