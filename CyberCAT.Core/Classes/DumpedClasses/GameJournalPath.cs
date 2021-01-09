using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameJournalPath")]
    public class GameJournalPath : IScriptable
    {
        [RealName("realPath")]
        [RealType("String")]
        public string RealPath { get; set; }
        
        [RealName("fileEntryIndex")]
        [RealType("Int32")]
        public int FileEntryIndex { get; set; }
        
        [RealName("className")]
        [RealType("CName")]
        public string ClassName { get; set; }
    }
}
