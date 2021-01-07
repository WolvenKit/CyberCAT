using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("LiftControllerPS")]
    public class LiftControllerPS : MasterControllerPS
    {
        [RealName("liftSetup")]
        public LiftSetup LiftSetup { get; set; }
        
        [RealName("activeFloor")]
        [RealType("Int32")]
        public int ActiveFloor { get; set; }
        
        [RealName("targetFloor")]
        [RealType("Int32")]
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
        [RealType("Bool")]
        public bool[] FloorsAuthorization { get; set; }
        
        [RealName("timeOnPause")]
        [RealType("Float")]
        public float TimeOnPause { get; set; }
        
        [RealName("isPlayerInsideLift")]
        [RealType("Bool")]
        public bool IsPlayerInsideLift { get; set; }
        
        [RealName("isSpeakerDestroyed")]
        [RealType("Bool")]
        public bool IsSpeakerDestroyed { get; set; }
        
        [RealName("hasSpeaker")]
        [RealType("Bool")]
        public bool HasSpeaker { get; set; }
        
        [RealName("stations")]
        public RadioStationsMap[] Stations { get; set; }
        
        [RealName("cachedGoToFloorAction")]
        [RealType("Int32")]
        public int CachedGoToFloorAction { get; set; }
        
        [RealName("isAllDoorsClosed")]
        [RealType("Bool")]
        public bool IsAllDoorsClosed { get; set; }
        
        [RealName("isAdsDisabled")]
        [RealType("Bool")]
        public bool IsAdsDisabled { get; set; }
    }
}
