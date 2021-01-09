using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("CluePSData")]
    public class CluePSData : IScriptable
    {
        [RealName("id")]
        [RealType("Int32")]
        public int Id { get; set; }
        
        [RealName("isEnabled")]
        [RealType("Bool")]
        public bool IsEnabled { get; set; }
        
        [RealName("wasInspected")]
        [RealType("Bool")]
        public bool WasInspected { get; set; }
        
        [RealName("isScanned")]
        [RealType("Bool")]
        public bool IsScanned { get; set; }
        
        [RealName("conclusionQuestState")]
        public DumpedEnums.EConclusionQuestState? ConclusionQuestState { get; set; }
    }
}
