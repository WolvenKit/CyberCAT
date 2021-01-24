using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("LiftControllerPS")]
    public class LiftControllerPS : MasterControllerPS
    {
        [RealName("liftSetup")]
        public LiftSetup LiftSetup { get; set; }
        
        [RealName("activeFloor")]
        public int ActiveFloor { get; set; }
        
        [RealName("targetFloor")]
        public int TargetFloor { get; set; }
        
        [RealName("movementState")]
        public DumpedEnums.gamePlatformMovementState? MovementState { get; set; }
        
        [RealName("floors")]
        public ElevatorFloorSetup[] Floors { get; set; }
        
        [RealName("floorIDs")]
        public EntEntityID[] FloorIDs { get; set; }
        
        [RealName("floorPSIDs")]
        public GamePersistentID[] FloorPSIDs { get; set; }
        
        [RealName("floorsAuthorization")]
        public bool[] FloorsAuthorization { get; set; }
        
        [RealName("timeOnPause")]
        public float TimeOnPause { get; set; }
        
        [RealName("isPlayerInsideLift")]
        public bool IsPlayerInsideLift { get; set; }
        
        [RealName("isSpeakerDestroyed")]
        public bool IsSpeakerDestroyed { get; set; }
        
        [RealName("hasSpeaker")]
        public bool HasSpeaker { get; set; }
        
        [RealName("stations")]
        public RadioStationsMap[] Stations { get; set; }
        
        [RealName("cachedGoToFloorAction")]
        public int CachedGoToFloorAction { get; set; }
        
        [RealName("isAllDoorsClosed")]
        public bool IsAllDoorsClosed { get; set; }
        
        [RealName("isAdsDisabled")]
        public bool IsAdsDisabled { get; set; }
    }
}
