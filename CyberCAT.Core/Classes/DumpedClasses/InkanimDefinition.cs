using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("inkanimDefinition")]
    public class InkanimDefinition : IScriptable
    {
        [RealName("interpolators")]
        public Handle<InkanimInterpolator>[] Interpolators { get; set; }
        
        [RealName("events")]
        public Handle<InkanimEvent>[] Events { get; set; }
    }
}
