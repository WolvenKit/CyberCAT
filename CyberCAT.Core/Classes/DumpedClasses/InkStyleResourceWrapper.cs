using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("inkStyleResourceWrapper")]
    public class InkStyleResourceWrapper : ISerializable
    {
        [RealName("styleResource")]
        public InkStyleResource StyleResource { get; set; }
    }
}
