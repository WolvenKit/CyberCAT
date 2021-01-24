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
        public bool IsShutter { get; set; }
        
        [RealName("initialDoorState")]
        public DumpedEnums.EDoorStatus? InitialDoorState { get; set; }
        
        [RealName("canPlayerToggleLockState")]
        public bool CanPlayerToggleLockState { get; set; }
        
        [RealName("canPlayerToggleSealState")]
        public bool CanPlayerToggleSealState { get; set; }
        
        [RealName("automaticallyClosesItself")]
        public bool AutomaticallyClosesItself { get; set; }
        
        [RealName("openingSpeed")]
        public float OpeningSpeed { get; set; }
        
        [RealName("doorOpeningTime")]
        public float DoorOpeningTime { get; set; }
        
        [RealName("doorOpeningStimRange")]
        public float DoorOpeningStimRange { get; set; }
        
        [RealName("canPayToUnlock")]
        public bool CanPayToUnlock { get; set; }
        
        [RealName("paymentRecordID")]
        public TweakDbId PaymentRecordID { get; set; }
        
        [RealName("exposeQuickHacksIfNotConnectedToAP")]
        public bool ExposeQuickHacksIfNotConnectedToAP { get; set; }

        public DoorSetup()
        {
            AutomaticallyClosesItself = true;
        }
    }
}
