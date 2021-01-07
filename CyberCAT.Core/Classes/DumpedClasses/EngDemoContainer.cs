using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("EngDemoContainer")]
    public class EngDemoContainer : BaseSkillCheckContainer
    {
        [RealName("engineeringCheck")]
        public Handle<EngineeringSkillCheck> EngineeringCheck { get; set; }
        
        [RealName("demolitionCheck")]
        public Handle<DemolitionSkillCheck> DemolitionCheck { get; set; }
    }
}
