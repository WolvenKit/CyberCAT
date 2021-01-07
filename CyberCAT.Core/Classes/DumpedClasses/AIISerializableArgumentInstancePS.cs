using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AIISerializableArgumentInstancePS")]
    public class AIISerializableArgumentInstancePS : AIArgumentInstancePS
    {
        [RealName("value")]
        public Handle<ISerializable> Value { get; set; }
    }
}
