using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gamedeviceDataElement")]
    public class GamedeviceDataElement : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("owner")]
        [RealType("String")]
        public string Owner { get; set; }
        
        [RealName("date")]
        [RealType("String")]
        public string Date { get; set; }
        
        [RealName("title")]
        [RealType("String")]
        public string Title { get; set; }
        
        [RealName("content")]
        [RealType("String")]
        public string Content { get; set; }
        
        [RealName("videoPath")]
        public RedResourceReferenceScriptToken VideoPath { get; set; }
        
        [RealName("journalPath")]
        public Handle<GameJournalPath> JournalPath { get; set; }
        
        [RealName("documentName")]
        [RealType("CName")]
        public string DocumentName { get; set; }
        
        [RealName("questInfo")]
        public GamedeviceQuestInfo QuestInfo { get; set; }
        
        [RealName("isEncrypted")]
        [RealType("Bool")]
        public bool IsEncrypted { get; set; }
        
        [RealName("wasRead")]
        [RealType("Bool")]
        public bool WasRead { get; set; }
        
        [RealName("isEnabled")]
        [RealType("Bool")]
        public bool IsEnabled { get; set; }
    }
}
