using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameJournalPath")]
    public class GameJournalPath : IScriptable
    {
        [RealName("realPath")]
        public string RealPath { get; set; }
        
        [RealName("fileEntryIndex")]
        public int FileEntryIndex { get; set; }
        
        [RealName("className")]
        public CName ClassName { get; set; }
    }
}
