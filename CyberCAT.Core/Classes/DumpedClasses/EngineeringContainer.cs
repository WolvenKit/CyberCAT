using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("EngineeringContainer")]
    public class EngineeringContainer : BaseSkillCheckContainer
    {
        [RealName("engineeringCheck")]
        public Handle<EngineeringSkillCheck> EngineeringCheck { get; set; }
    }
}
