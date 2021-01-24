using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("WeaponVendingMachineSetup")]
    public class WeaponVendingMachineSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("vendorTweakID")]
        public TweakDbId VendorTweakID { get; set; }
        
        [RealName("junkItemID")]
        public TweakDbId JunkItemID { get; set; }
        
        [RealName("timeToCompletePurchase")]
        public float TimeToCompletePurchase { get; set; }
    }
}
