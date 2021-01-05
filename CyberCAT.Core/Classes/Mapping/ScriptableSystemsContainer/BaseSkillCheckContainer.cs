using CyberCAT.Core.Classes.Mapping.Global;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
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
