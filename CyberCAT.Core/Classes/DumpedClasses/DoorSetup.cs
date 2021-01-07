using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DoorSetup")]
    public class DoorSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("doorType")]
        public DumpedEnums.EDoorType? DoorType { get; set; }
        
        [RealName("doorTypeSideOne")]
        public DumpedEnums.EDoorType? DoorTypeSideOne { get; set; }
        
        [RealName("doorTypeSideTwo")]
        public DumpedEnums.EDoorType? DoorTypeSideTwo { get; set; }
        
        [RealName("skillCheckSide")]
        public DumpedEnums.EDoorSkillcheckSide? SkillCheckSide { get; set; }
        
        [RealName("authorizationSide")]
        public DumpedEnums.EDoorSkillcheckSide? AuthorizationSide { get; set; }
        
        [RealName("doorTriggerSide")]
        public DumpedEnums.EDoorTriggerSide? DoorTriggerSide { get; set; }
        
        [RealName("isShutter")]
        [RealType("Bool")]
        public bool IsShutter { get; set; }
        
        [RealName("initialDoorState")]
        public DumpedEnums.EDoorStatus? InitialDoorState { get; set; }
        
        [RealName("canPlayerToggleLockState")]
        [RealType("Bool")]
        public bool CanPlayerToggleLockState { get; set; }
        
        [RealName("canPlayerToggleSealState")]
        [RealType("Bool")]
        public bool CanPlayerToggleSealState { get; set; }
        
        [RealName("automaticallyClosesItself")]
        [RealType("Bool")]
        public bool AutomaticallyClosesItself { get; set; }
        
        [RealName("openingSpeed")]
        [RealType("Float")]
        public float OpeningSpeed { get; set; }
        
        [RealName("doorOpeningTime")]
        [RealType("Float")]
        public float DoorOpeningTime { get; set; }
        
        [RealName("doorOpeningStimRange")]
        [RealType("Float")]
        public float DoorOpeningStimRange { get; set; }
        
        [RealName("canPayToUnlock")]
        [RealType("Bool")]
        public bool CanPayToUnlock { get; set; }
        
        [RealName("paymentRecordID")]
        [RealType("TweakDBID")]
        public TweakDbId PaymentRecordID { get; set; }
        
        [RealName("exposeQuickHacksIfNotConnectedToAP")]
        [RealType("Bool")]
        public bool ExposeQuickHacksIfNotConnectedToAP { get; set; }

        public DoorSetup()
        {
            AutomaticallyClosesItself = true;
        }
    }
}
