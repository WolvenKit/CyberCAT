using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("HighlightInstance")]
    public class HighlightInstance : ModuleInstance
    {
        [RealName("context")]
        public DumpedEnums.HighlightContext? Context { get; set; }
        
        [RealName("instant")]
        public bool Instant { get; set; }
    }
}
