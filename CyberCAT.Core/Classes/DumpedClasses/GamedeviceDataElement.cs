using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gamedeviceDataElement")]
    public class GamedeviceDataElement : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("journalPath")]
        public Handle<GameJournalPath> JournalPath { get; set; }
        
        [RealName("documentName")]
        public CName DocumentName { get; set; }
        
        [RealName("owner")]
        public string Owner { get; set; }
        
        [RealName("date")]
        public string Date { get; set; }
        
        [RealName("title")]
        public string Title { get; set; }
        
        [RealName("content")]
        public string Content { get; set; }
        
        [RealName("videoPath")]
        public RedResourceReferenceScriptToken VideoPath { get; set; }
        
        [RealName("questInfo")]
        public GamedeviceQuestInfo QuestInfo { get; set; }
        
        [RealName("isEncrypted")]
        public bool IsEncrypted { get; set; }
        
        [RealName("wasRead")]
        public bool WasRead { get; set; }
        
        [RealName("isEnabled")]
        public bool IsEnabled { get; set; }

        public GamedeviceDataElement()
        {
            IsEnabled = true;
        }
    }
}
