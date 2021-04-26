using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("VehicleComponent")]
    public class VehicleComponent : ScriptableDC
    {
        [RealName("interaction")]
        public Handle<GameinteractionsComponent> Interaction { get; set; }
        
        [RealName("scanningComponent")]
        public Handle<GameScanningComponent> ScanningComponent { get; set; }
        
        [RealName("damageLevel")]
        public int DamageLevel { get; set; }
        
        [RealName("coolerDestro")]
        public bool CoolerDestro { get; set; }
        
        [RealName("submerged")]
        public bool Submerged { get; set; }
        
        [RealName("bumperFrontState")]
        public int BumperFrontState { get; set; }
        
        [RealName("bumperBackState")]
        public int BumperBackState { get; set; }
        
        [RealName("visualDestructionSet")]
        public bool VisualDestructionSet { get; set; }
        
        [RealName("healthStatPoolListener")]
        public Handle<VehicleHealthStatPoolListener> HealthStatPoolListener { get; set; }
        
        [RealName("vehicleBlackboard")]
        public GameIBlackboard VehicleBlackboard { get; set; }
        
        [RealName("radioState")]
        public bool RadioState { get; set; }
        
        [RealName("mounted")]
        public bool Mounted { get; set; }
        
        [RealName("enterTime")]
        public float EnterTime { get; set; }
        
        [RealName("mappinID")]
        public GameNewMappinID MappinID { get; set; }
        
        [RealName("ignoreAutoDoorClose")]
        public bool IgnoreAutoDoorClose { get; set; }
        
        [RealName("timeSystemCallbackID")]
        public uint TimeSystemCallbackID { get; set; }
        
        [RealName("vehicleTPPCallbackID")]
        public uint VehicleTPPCallbackID { get; set; }
        
        [RealName("vehicleSpeedCallbackID")]
        public uint VehicleSpeedCallbackID { get; set; }
        
        [RealName("vehicleRPMCallbackID")]
        public uint VehicleRPMCallbackID { get; set; }
        
        [RealName("broadcasting")]
        public bool Broadcasting { get; set; }
        
        [RealName("hasSpoiler")]
        public bool HasSpoiler { get; set; }
        
        [RealName("spoilerUp")]
        public float SpoilerUp { get; set; }
        
        [RealName("spoilerDown")]
        public float SpoilerDown { get; set; }
        
        [RealName("spoilerDeployed")]
        public bool SpoilerDeployed { get; set; }
        
        [RealName("hasTurboCharger")]
        public bool HasTurboCharger { get; set; }
        
        [RealName("overheatEffectBlackboard")]
        public Handle<WorldEffectBlackboard> OverheatEffectBlackboard { get; set; }
        
        [RealName("overheatActive")]
        public bool OverheatActive { get; set; }
        
        [RealName("hornOn")]
        public bool HornOn { get; set; }
        
        [RealName("hasSiren")]
        public bool HasSiren { get; set; }
        
        [RealName("hornPressTime")]
        public float HornPressTime { get; set; }
        
        [RealName("radioPressTime")]
        public float RadioPressTime { get; set; }
        
        [RealName("raceClockTickID")]
        public GameDelayID RaceClockTickID { get; set; }
        
        [RealName("objectActionsCallbackCtrl")]
        public Handle<GameObjectActionsCallbackController> ObjectActionsCallbackCtrl { get; set; }
        
        [RealName("mountedPlayer")]
        public PlayerPuppet MountedPlayer { get; set; }
        
        [RealName("isIgnoredInTargetingSystem")]
        public bool IsIgnoredInTargetingSystem { get; set; }
        
        [RealName("arePlayerHitShapesEnabled")]
        public bool ArePlayerHitShapesEnabled { get; set; }
        
        [RealName("vehicleController")]
        public Handle<VehicleController> VehicleController { get; set; }
    }
}
