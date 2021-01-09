using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ActionsSequence")]
    public class ActionsSequence : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("sequenceInitiator")]
        public EntEntityID SequenceInitiator { get; set; }
        
        [RealName("maxActionsInSequence")]
        [RealType("Int32")]
        public int MaxActionsInSequence { get; set; }
        
        [RealName("actionsTriggeredCount")]
        [RealType("Int32")]
        public int ActionsTriggeredCount { get; set; }
        
        [RealName("delayIDs")]
        public GameDelayID[] DelayIDs { get; set; }
    }
}
