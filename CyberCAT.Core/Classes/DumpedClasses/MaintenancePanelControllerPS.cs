using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("MaintenancePanelControllerPS")]
    public class MaintenancePanelControllerPS : MasterControllerPS
    {
        [RealName("maintenancePanelSkillChecks")]
        public Handle<EngineeringContainer> MaintenancePanelSkillChecks { get; set; }
    }
}
