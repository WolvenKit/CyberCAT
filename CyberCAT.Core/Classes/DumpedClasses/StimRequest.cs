using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("StimRequest")]
    public class StimRequest : IScriptable
    {
        [RealName("stimuli")]
        public Handle<SenseStimuliEvent> Stimuli { get; set; }
        
        [RealName("hasExpirationDate")]
        public bool HasExpirationDate { get; set; }
        
        [RealName("duration")]
        public float Duration { get; set; }
        
        [RealName("requestID")]
        public StimRequestID RequestID { get; set; }
    }
}
