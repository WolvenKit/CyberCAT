using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("GemplayObjectiveData")]
    public class GemplayObjectiveData : IScriptable
    {
        [RealName("questUniqueId")]
        public string QuestUniqueId { get; set; }
        
        [RealName("questTitle")]
        public string QuestTitle { get; set; }
        
        [RealName("objectiveDescription")]
        public string ObjectiveDescription { get; set; }
        
        [RealName("uniqueId")]
        public string UniqueId { get; set; }
        
        [RealName("ownerID")]
        public EntEntityID OwnerID { get; set; }
        
        [RealName("objectiveEntryID")]
        public string ObjectiveEntryID { get; set; }
        
        [RealName("uniqueIdPrefix")]
        public string UniqueIdPrefix { get; set; }
        
        [RealName("objectiveState")]
        public DumpedEnums.gameJournalEntryState? ObjectiveState { get; set; }
    }
}
