using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("ClueRecordData")]
    public class ClueRecordData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("clueRecord")]
        [RealType("TweakDBID")]
        public TweakDbId ClueRecord { get; set; }
        
        [RealName("percentage")]
        [RealType("Float")]
        public float Percentage { get; set; }
        
        [RealName("facts")]
        public SFactOperationData[] Facts { get; set; }
        
        [RealName("wasInspected")]
        [RealType("Bool")]
        public bool WasInspected { get; set; }
    }
}
