using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AIBoolArgumentInstancePS")]
    public class AIBoolArgumentInstancePS : AIArgumentInstancePS
    {
        [RealName("value")]
        [RealType("Bool")]
        public bool Value { get; set; }
    }
}
