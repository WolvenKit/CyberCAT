using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("RevealRequestsStorage")]
    public class RevealRequestsStorage : IScriptable
    {
        [RealName("currentRequestersAmount")]
        public int CurrentRequestersAmount { get; set; }
        
        [RealName("requestersList")]
        public EntEntityID[] RequestersList { get; set; }
    }
}
