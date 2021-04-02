using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("StimBroadcasterComponent")]
    public class StimBroadcasterComponent : GameScriptableComponent
    {
        [RealName("activeRequests")]
        public Handle<StimRequest>[] ActiveRequests { get; set; }
        
        [RealName("currentID")]
        public uint CurrentID { get; set; }
        
        [RealName("shouldBroadcast")]
        public bool ShouldBroadcast { get; set; }
        
        [RealName("targets")]
        public NPCstubData[] Targets { get; set; }
        
        [RealName("fallbackInterval")]
        public float FallbackInterval { get; set; }
    }
}
