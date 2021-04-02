using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DistrictManager")]
    public class DistrictManager : IScriptable
    {
        [RealName("system")]
        public PreventionSystem System { get; set; }
        
        [RealName("stack")]
        public Handle<District>[] Stack { get; set; }
        
        [RealName("visitedDistricts")]
        public TweakDbId[] VisitedDistricts { get; set; }
    }
}
