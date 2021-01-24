using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DistrictManager")]
    public class DistrictManager : IScriptable
    {
        [RealName("stack")]
        public Handle<District>[] Stack { get; set; }
        
        [RealName("visitedDistricts")]
        public TweakDbId[] VisitedDistricts { get; set; }
    }
}
