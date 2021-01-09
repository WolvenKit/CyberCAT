using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AIFollowerRole")]
    public class AIFollowerRole : AIRole
    {
        [RealName("followerRef")]
        public GameEntityReference FollowerRef { get; set; }

        [RealName("attitudeGroupName")]
        [RealType("CName")]
        public string AttitudeGroupName { get; set; }

        [RealName("followTargetSquads")]
        [RealType("CName")]
        public string[] FollowTargetSquads { get; set; }

        [RealName("playerCombatListener")]
        [RealType("Uint32")]
        public uint PlayerCombatListener { get; set; }

        [RealName("lastStealthLeaveTimeStamp")]
        public EngineTime LastStealthLeaveTimeStamp { get; set; }

        [RealName("friendlyTargetSlotListener")]
        public Handle<GameAttachmentSlotsScriptListener> FriendlyTargetSlotListener { get; set; }

        [RealName("ownerTargetSlotListener")]
        public Handle<GameAttachmentSlotsScriptListener> OwnerTargetSlotListener { get; set; }

        [RealName("isFriendMelee")]
        [RealType("Bool")]
        public bool IsFriendMelee { get; set; }

        [RealName("isOwnerSniper")]
        [RealType("Bool")]
        public bool IsOwnerSniper { get; set; }
    }
}