using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("LinkedFocusClueData")]
    public class LinkedFocusClueData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("clueGroupID")]
        public CName ClueGroupID { get; set; }
        
        [RealName("ownerID")]
        public EntEntityID OwnerID { get; set; }
        
        [RealName("clueIndex")]
        public int ClueIndex { get; set; }
        
        [RealName("clueRecord")]
        public TweakDbId ClueRecord { get; set; }
        
        [RealName("extendedClueRecords")]
        public ClueRecordData[] ExtendedClueRecords { get; set; }
        
        [RealName("isScanned")]
        public bool IsScanned { get; set; }
        
        [RealName("wasInspected")]
        public bool WasInspected { get; set; }
        
        [RealName("isEnabled")]
        public bool IsEnabled { get; set; }
        
        [RealName("psData")]
        public PSOwnerData PsData { get; set; }
    }
}
