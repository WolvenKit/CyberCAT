using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameVisionModeSystemRevealIdentifier")]
    public class GameVisionModeSystemRevealIdentifier : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("sourceEntityId")]
        public EntEntityID SourceEntityId { get; set; }
        
        [RealName("reason")]
        public CName Reason { get; set; }
    }
}
