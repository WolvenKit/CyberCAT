using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("HitHistory")]
    public class HitHistory : IScriptable
    {
        [RealName("hitHistory")]
        public HitHistoryItem[] HitHistoryProp { get; set; }
        
        [RealName("maxEntries")]
        public int MaxEntries { get; set; }
    }
}
