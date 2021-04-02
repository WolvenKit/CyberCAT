using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("OutlineRequest")]
    public class OutlineRequest : IScriptable
    {
        [RealName("requester")]
        public CName Requester { get; set; }
        
        [RealName("shouldAdd")]
        public bool ShouldAdd { get; set; }
        
        [RealName("outlineDuration")]
        public float OutlineDuration { get; set; }
        
        [RealName("outlineData")]
        public OutlineData OutlineData { get; set; }
    }
}
