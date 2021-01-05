
using CyberCAT.Core.Classes.Mapping.Global;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("GemplayObjectiveData")]
    public class GemplayObjectiveData : IScriptable
    {
        [RealName("questUniqueId")]
        [RealType("String")]
        public string QuestUniqueId { get; set; }
        
        [RealName("questTitle")]
        [RealType("String")]
        public string QuestTitle { get; set; }
        
        [RealName("objectiveDescription")]
        [RealType("String")]
        public string ObjectiveDescription { get; set; }
        
        [RealName("uniqueId")]
        [RealType("String")]
        public string UniqueId { get; set; }
        
        [RealName("ownerID")]
        public EntEntityID OwnerID { get; set; }
        
        [RealName("objectiveEntryID")]
        [RealType("String")]
        public string ObjectiveEntryID { get; set; }
        
        [RealName("uniqueIdPrefix")]
        [RealType("String")]
        public string UniqueIdPrefix { get; set; }
        
        [RealName("objectiveState")]
        public DumpedEnums.gameJournalEntryState? ObjectiveState { get; set; }
    }
}
