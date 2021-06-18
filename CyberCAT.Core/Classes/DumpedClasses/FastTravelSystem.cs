using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("FastTravelSystem")]
    public class FastTravelSystem : GameScriptableSystem
    {
        [RealName("fastTravelNodes")]
        public Handle<GameFastTravelPointData>[] FastTravelNodes { get; set; }
        
        [RealName("isFastTravelEnabledOnMap")]
        public bool IsFastTravelEnabledOnMap { get; set; }
        
        [RealName("fastTravelPointsTotal")]
        public int FastTravelPointsTotal { get; set; }

        [RealName("lastUpdatedAchievementCount")]
        public int LastUpdatedAchievementCount { get; set; }

        [RealName("fastTravelLocks")]
        public FastTravelSystemLock[] FastTravelLocks { get; set; }
        
        [RealName("loadingScreenCallbackID")]
        public uint LoadingScreenCallbackID { get; set; }
        
        [RealName("requestAutoSafeAfterLoadingScreen")]
        public bool RequestAutoSafeAfterLoadingScreen { get; set; }

        [RealName("lockLisenerID")]
        public CName LockLisenerID { get; set; }

        [RealName("unlockLisenerID")]
        public CName UnlockLisenerID { get; set; }

        [RealName("removeAllLocksLisenerID")]
        public CName RemoveAllLocksLisenerID { get; set; }
    }
}
