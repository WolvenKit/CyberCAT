using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("WeaponVendingMachineSetup")]
    public class WeaponVendingMachineSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("vendorTweakID")]
        [RealType("TweakDBID")]
        public TweakDbId VendorTweakID { get; set; }
        
        [RealName("junkItemID")]
        [RealType("TweakDBID")]
        public TweakDbId JunkItemID { get; set; }
        
        [RealName("timeToCompletePurchase")]
        [RealType("Float")]
        public float TimeToCompletePurchase { get; set; }
    }
}
