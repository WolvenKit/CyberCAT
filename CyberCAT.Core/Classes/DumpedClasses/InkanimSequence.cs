using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("inkanimSequence")]
    public class InkanimSequence : IScriptable
    {
        [RealName("name")]
        public CName Name { get; set; }
        
        [RealName("definitions")]
        public Handle<InkanimDefinition>[] Definitions { get; set; }
        
        [RealName("targets")]
        public Handle<InkanimSequenceTargetInfo>[] Targets { get; set; }
    }
}
