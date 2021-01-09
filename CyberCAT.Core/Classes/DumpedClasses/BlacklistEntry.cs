using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("BlacklistEntry")]
    public class BlacklistEntry : IScriptable
    {
        [RealName("entryID")]
        public EntEntityID EntryID { get; set; }
        
        [RealName("entryReason")]
        public DumpedEnums.BlacklistReason? EntryReason { get; set; }
        
        [RealName("warningsCount")]
        [RealType("Int32")]
        public int WarningsCount { get; set; }
        
        [RealName("reprimandID")]
        [RealType("Int32")]
        public int ReprimandID { get; set; }
    }
}
