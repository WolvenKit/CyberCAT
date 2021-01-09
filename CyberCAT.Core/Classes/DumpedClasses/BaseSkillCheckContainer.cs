using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("BaseSkillCheckContainer")]
    public class BaseSkillCheckContainer : IScriptable
    {
        [RealName("hackingCheckSlot")]
        public Handle<HackingSkillCheck> HackingCheckSlot { get; set; }
        
        [RealName("engineeringCheckSlot")]
        public Handle<EngineeringSkillCheck> EngineeringCheckSlot { get; set; }
        
        [RealName("demolitionCheckSlot")]
        public Handle<DemolitionSkillCheck> DemolitionCheckSlot { get; set; }
    }
}
