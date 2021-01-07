using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("HackingContainer")]
    public class HackingContainer : BaseSkillCheckContainer
    {
        [RealName("hackingCheck")]
        public Handle<HackingSkillCheck> HackingCheck { get; set; }
    }
}
