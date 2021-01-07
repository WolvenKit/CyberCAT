using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DemolitionContainer")]
    public class DemolitionContainer : BaseSkillCheckContainer
    {
        [RealName("demolitionCheck")]
        public Handle<DemolitionSkillCheck> DemolitionCheck { get; set; }
    }
}
