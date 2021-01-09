using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AIArgumentInstancePS")]
    public class AIArgumentInstancePS : ISerializable
    {
        [RealName("name")]
        [RealType("CName")]
        public string Name { get; set; }
    }
}
