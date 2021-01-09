using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("FastTravelSystem")]
    public class FastTravelSystem : GameScriptableSystem
    {
        [RealName("fastTravelNodes")]
        public Handle<GameFastTravelPointData>[] FastTravelNodes { get; set; }
        
        [RealName("isFastTravelEnabledOnMap")]
        [RealType("Bool")]
        public bool IsFastTravelEnabledOnMap { get; set; }
        
        [RealName("fastTravelPointsTotal")]
        [RealType("Int32")]
        public int FastTravelPointsTotal { get; set; }
        
        [RealName("fastTravelLocks")]
        public FastTravelSystemLock[] FastTravelLocks { get; set; }
        
        [RealName("loadingScreenCallbackID")]
        [RealType("Uint32")]
        public uint LoadingScreenCallbackID { get; set; }
        
        [RealName("requestAutoSafeAfterLoadingScreen")]
        [RealType("Bool")]
        public bool RequestAutoSafeAfterLoadingScreen { get; set; }
    }
}
