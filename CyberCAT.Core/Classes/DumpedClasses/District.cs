using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("District")]
    public class District : IScriptable
    {
        [RealName("districtID")]
        [RealType("TweakDBID")]
        public TweakDbId DistrictID { get; set; }
        
        [RealName("presetID")]
        [RealType("TweakDBID")]
        public TweakDbId PresetID { get; set; }
    }
}
