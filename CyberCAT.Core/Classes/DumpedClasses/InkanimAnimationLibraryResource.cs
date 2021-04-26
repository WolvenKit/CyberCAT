using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("inkanimAnimationLibraryResource")]
    public class InkanimAnimationLibraryResource : CResource
    {
        [RealName("sequences")]
        public Handle<InkanimSequence>[] Sequences { get; set; }
    }
}
