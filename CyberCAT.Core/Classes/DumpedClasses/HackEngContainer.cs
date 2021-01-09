using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("HackEngContainer")]
    public class HackEngContainer : BaseSkillCheckContainer
    {
        [RealName("hackingCheck")]
        public Handle<HackingSkillCheck> HackingCheck { get; set; }
        
        [RealName("engineeringCheck")]
        public Handle<EngineeringSkillCheck> EngineeringCheck { get; set; }
    }
}
