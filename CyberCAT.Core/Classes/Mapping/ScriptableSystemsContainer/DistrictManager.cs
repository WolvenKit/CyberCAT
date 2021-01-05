using CyberCAT.Core.Classes.Mapping.Global;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("DistrictManager")]
    public class DistrictManager : IScriptable
    {
        [RealName("stack")]
        public Handle<District>[] Stack { get; set; }
        
        [RealName("visitedDistricts")]
        [RealType("TweakDBID")]
        public ulong[] VisitedDistricts { get; set; }
    }
}
