using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ClueRecordData")]
    public class ClueRecordData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("clueRecord")]
        public TweakDbId ClueRecord { get; set; }
        
        [RealName("percentage")]
        public float Percentage { get; set; }
        
        [RealName("facts")]
        public SFactOperationData[] Facts { get; set; }
        
        [RealName("wasInspected")]
        public bool WasInspected { get; set; }
    }
}
