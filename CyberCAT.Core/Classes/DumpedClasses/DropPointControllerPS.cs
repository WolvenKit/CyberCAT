using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DropPointControllerPS")]
    public class DropPointControllerPS : BasicDistractionDeviceControllerPS
    {
        [RealName("vendorRecord")]
        public string VendorRecord { get; set; }
        
        [RealName("rewardsLootTable")]
        public TweakDbId[] RewardsLootTable { get; set; }
        
        [RealName("hasPlayerCollectedReward")]
        public bool HasPlayerCollectedReward { get; set; }
    }
}
