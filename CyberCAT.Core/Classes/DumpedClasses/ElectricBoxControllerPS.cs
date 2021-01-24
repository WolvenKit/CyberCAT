using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ElectricBoxControllerPS")]
    public class ElectricBoxControllerPS : MasterControllerPS
    {
        [RealName("techieSkillChecks")]
        public Handle<EngineeringContainer> TechieSkillChecks { get; set; }
        
        [RealName("questFactSetup")]
        public ComputerQuickHackData QuestFactSetup { get; set; }
        
        [RealName("isOverriden")]
        public bool IsOverriden { get; set; }

        public ElectricBoxControllerPS()
        {
            AutoToggleQuestMark = true;
        }
    }
}
