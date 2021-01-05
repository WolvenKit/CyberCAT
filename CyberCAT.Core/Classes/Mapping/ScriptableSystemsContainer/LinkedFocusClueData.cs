using CyberCAT.Core.Classes.Mapping.Global;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("LinkedFocusClueData")]
    public class LinkedFocusClueData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("clueGroupID")]
        [RealType("CName")]
        public string ClueGroupID { get; set; }
        
        [RealName("ownerID")]
        public EntEntityID OwnerID { get; set; }
        
        [RealName("clueIndex")]
        [RealType("Int32")]
        public int ClueIndex { get; set; }
        
        [RealName("clueRecord")]
        [RealType("TweakDBID")]
        public ulong ClueRecord { get; set; }
        
        [RealName("extendedClueRecords")]
        public ClueRecordData[] ExtendedClueRecords { get; set; }
        
        [RealName("isScanned")]
        [RealType("Bool")]
        public bool IsScanned { get; set; }
        
        [RealName("wasInspected")]
        [RealType("Bool")]
        public bool WasInspected { get; set; }
        
        [RealName("isEnabled")]
        [RealType("Bool")]
        public bool IsEnabled { get; set; }
        
        [RealName("psData")]
        public PSOwnerData PsData { get; set; }
    }
}
