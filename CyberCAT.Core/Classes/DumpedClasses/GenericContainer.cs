using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("GenericContainer")]
    public class GenericContainer : BaseSkillCheckContainer
    {
        [RealName("hackingCheck")]
        public Handle<HackingSkillCheck> HackingCheck { get; set; }
        
        [RealName("engineeringCheck")]
        public Handle<EngineeringSkillCheck> EngineeringCheck { get; set; }
        
        [RealName("demolitionCheck")]
        public Handle<DemolitionSkillCheck> DemolitionCheck { get; set; }
    }
}
