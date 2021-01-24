using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AIArgumentInstancePS")]
    public class AIArgumentInstancePS : ISerializable
    {
        [RealName("name")]
        public CName Name { get; set; }
    }
}
