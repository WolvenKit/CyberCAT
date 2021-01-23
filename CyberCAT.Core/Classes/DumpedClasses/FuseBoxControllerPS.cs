using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("FuseBoxControllerPS")]
    public class FuseBoxControllerPS : MasterControllerPS
    {
        [RealName("fuseBoxSkillChecks")]
        public Handle<EngineeringContainer> FuseBoxSkillChecks { get; set; }
        
        [RealName("isGenerator")]
        public bool IsGenerator { get; set; }
        
        [RealName("isOverloaded")]
        public bool IsOverloaded { get; set; }
    }
}
