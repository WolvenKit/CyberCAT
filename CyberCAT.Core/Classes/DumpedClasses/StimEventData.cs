using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("StimEventData")]
    public class StimEventData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("source")]
        public GameObject Source { get; set; }
        
        [RealName("stimType")]
        public DumpedEnums.gamedataStimType? StimType { get; set; }
        
        [RealName("tags")]
        public CName[] Tags { get; set; }
    }
}
