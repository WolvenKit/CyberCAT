using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gamedeviceQuestInfo")]
    public class GamedeviceQuestInfo : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("isHighlighted")]
        public bool IsHighlighted { get; set; }
        
        [RealName("factName")]
        public CName FactName { get; set; }
    }
}
