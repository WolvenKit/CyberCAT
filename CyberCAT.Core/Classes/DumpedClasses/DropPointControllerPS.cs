using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DropPointControllerPS")]
    public class DropPointControllerPS : BasicDistractionDeviceControllerPS
    {
        [RealName("vendorRecord")]
        [RealType("String")]
        public string VendorRecord { get; set; }
        
        [RealName("rewardsLootTable")]
        [RealType("TweakDBID")]
        public TweakDbId[] RewardsLootTable { get; set; }
        
        [RealName("hasPlayerCollectedReward")]
        [RealType("Bool")]
        public bool HasPlayerCollectedReward { get; set; }
    }
}
