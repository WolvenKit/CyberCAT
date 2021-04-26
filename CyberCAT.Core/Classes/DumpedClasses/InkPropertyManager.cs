using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("inkPropertyManager")]
    public class InkPropertyManager : ISerializable
    {
        [RealName("bindings")]
        public InkPropertyBinding[] Bindings { get; set; }
    }
}
