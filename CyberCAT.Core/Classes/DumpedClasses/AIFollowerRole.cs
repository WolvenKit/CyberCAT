using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AIFollowerRole")]
    public class AIFollowerRole : AIRole
    {
        [RealName("followerRef")]
        public GameEntityReference FollowerRef { get; set; }
        
        [RealName("attitudeGroupName")]
        public CName AttitudeGroupName { get; set; }
        
        [RealName("followTargetSquads")]
        public CName[] FollowTargetSquads { get; set; }
        
        [RealName("playerCombatListener")]
        public uint PlayerCombatListener { get; set; }
        
        [RealName("lastStealthLeaveTimeStamp")]
        public EngineTime LastStealthLeaveTimeStamp { get; set; }
        
        [RealName("friendlyTargetSlotListener")]
        public Handle<GameAttachmentSlotsScriptListener> FriendlyTargetSlotListener { get; set; }
        
        [RealName("ownerTargetSlotListener")]
        public Handle<GameAttachmentSlotsScriptListener> OwnerTargetSlotListener { get; set; }
        
        [RealName("isFriendMelee")]
        public bool IsFriendMelee { get; set; }
        
        [RealName("isOwnerSniper")]
        public bool IsOwnerSniper { get; set; }
    }
}