using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("FocusClueDefinition")]
    public class FocusClueDefinition : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("extendedClueRecords")]
        public ClueRecordData[] ExtendedClueRecords { get; set; }
        
        [RealName("clueRecord")]
        public TweakDbId ClueRecord { get; set; }
        
        [RealName("factToActivate")]
        public CName FactToActivate { get; set; }
        
        [RealName("facts")]
        public SFactOperationData[] Facts { get; set; }
        
        [RealName("useAutoInspect")]
        public bool UseAutoInspect { get; set; }
        
        [RealName("isEnabled")]
        public bool IsEnabled { get; set; }
        
        [RealName("isProgressing")]
        public bool IsProgressing { get; set; }
        
        [RealName("clueGroupID")]
        public CName ClueGroupID { get; set; }
        
        [RealName("wasInspected")]
        public bool WasInspected { get; set; }
        
        [RealName("qDbCallbackID")]
        public uint QDbCallbackID { get; set; }
        
        [RealName("conclusionQuestState")]
        public DumpedEnums.EConclusionQuestState? ConclusionQuestState { get; set; }
    }
}
