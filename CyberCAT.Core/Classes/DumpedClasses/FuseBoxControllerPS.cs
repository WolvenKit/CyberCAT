using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("FuseBoxControllerPS")]
    public class FuseBoxControllerPS : MasterControllerPS
    {
        [RealName("fuseBoxSkillChecks")]
        public Handle<EngineeringContainer> FuseBoxSkillChecks { get; set; }
        
        [RealName("isGenerator")]
        [RealType("Bool")]
        public bool IsGenerator { get; set; }
        
        [RealName("isOverloaded")]
        [RealType("Bool")]
        public bool IsOverloaded { get; set; }
    }
}
