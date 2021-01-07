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
        [RealType("Float")]
        public float SoldOutProbability { get; set; }
        
        [RealName("isReady")]
        [RealType("Bool")]
        public bool IsReady { get; set; }
        
        [RealName("isSoldOut")]
        [RealType("Bool")]
        public bool IsSoldOut { get; set; }
        
        [RealName("hackCount")]
        [RealType("Int32")]
        public int HackCount { get; set; }
        
        [RealName("shopStock")]
        public GameSItemStack[] ShopStock { get; set; }
        
        [RealName("shopStockInit")]
        [RealType("Bool")]
        public bool ShopStockInit { get; set; }
    }
}
