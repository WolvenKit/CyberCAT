using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SecuritySystemInput")]
    public class SecuritySystemInput : SecurityAreaEvent
    {
        [RealName("lastKnownPosition")]
        public Vector4 LastKnownPosition { get; set; }
        
        [RealName("notifier")]
        public Handle<SharedGameplayPS> Notifier { get; set; }
        
        [RealName("type")]
        public DumpedEnums.ESecurityNotificationType? Type { get; set; }
        
        [RealName("objectOfInterest")]
        public GameObject ObjectOfInterest { get; set; }
        
        [RealName("canPerformReprimand")]
        public bool CanPerformReprimand { get; set; }
        
        [RealName("shouldLeadReprimend")]
        public bool ShouldLeadReprimend { get; set; }
        
        [RealName("id")]
        public int Id { get; set; }
        
        [RealName("customRecipientsList")]
        public EntEntityID[] CustomRecipientsList { get; set; }
        
        [RealName("isSharingRestricted")]
        public bool IsSharingRestricted { get; set; }
        
        [RealName("debugReporterCharRecord")]
        public Handle<GamedataCharacter_Record> DebugReporterCharRecord { get; set; }
        
        [RealName("stimTypeTriggeredAlarm")]
        public DumpedEnums.gamedataStimType? StimTypeTriggeredAlarm { get; set; }
    }
}
