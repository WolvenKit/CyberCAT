using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("CluePSData")]
    public class CluePSData : IScriptable
    {
        [RealName("id")]
        public int Id { get; set; }
        
        [RealName("isEnabled")]
        public bool IsEnabled { get; set; }
        
        [RealName("wasInspected")]
        public bool WasInspected { get; set; }
        
        [RealName("isScanned")]
        public bool IsScanned { get; set; }
        
        [RealName("conclusionQuestState")]
        public DumpedEnums.EConclusionQuestState? ConclusionQuestState { get; set; }
    }
}
