using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("inkanimSequenceTargetInfo")]
    public class InkanimSequenceTargetInfo : ISerializable
    {
        [RealName("path")]
        public uint[] Path { get; set; }
    }
}
