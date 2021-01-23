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
        
        [RealName("fastTravelLocks")]
        public FastTravelSystemLock[] FastTravelLocks { get; set; }
        
        [RealName("loadingScreenCallbackID")]
        public uint LoadingScreenCallbackID { get; set; }
        
        [RealName("requestAutoSafeAfterLoadingScreen")]
        public bool RequestAutoSafeAfterLoadingScreen { get; set; }
    }
}
