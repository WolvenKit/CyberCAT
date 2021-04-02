using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("OutlineRequestManager")]
    public class OutlineRequestManager : IScriptable
    {
        [RealName("requestsList")]
        public Handle<OutlineRequest>[] RequestsList { get; set; }
        
        [RealName("owner")]
        public GameObject Owner { get; set; }
        
        [RealName("isBlocked")]
        public bool IsBlocked { get; set; }
        
        [RealName("dbgRequests")]
        public Handle<OutlineRequest>[] DbgRequests { get; set; }
    }
}
