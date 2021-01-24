using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ActionsSequencerControllerPS")]
    public class ActionsSequencerControllerPS : MasterControllerPS
    {
        [RealName("sequenceDuration")]
        public float SequenceDuration { get; set; }
        
        [RealName("sequencerMode")]
        public DumpedEnums.EActionsSequencerMode? SequencerMode { get; set; }
        
        [RealName("actionTypeToForward")]
        public SActionTypeForward ActionTypeToForward { get; set; }
        
        [RealName("ongoingSequence")]
        public ActionsSequence OngoingSequence { get; set; }
    }
}
