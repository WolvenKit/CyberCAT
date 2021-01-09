using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gamedeviceQuestInfo")]
    public class GamedeviceQuestInfo : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("isHighlighted")]
        [RealType("Bool")]
        public bool IsHighlighted { get; set; }
        
        [RealName("factName")]
        [RealType("CName")]
        public string FactName { get; set; }
    }
}
