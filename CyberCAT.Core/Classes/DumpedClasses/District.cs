using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("District")]
    public class District : IScriptable
    {
        [RealName("districtID")]
        public TweakDbId DistrictID { get; set; }
        
        [RealName("presetID")]
        public TweakDbId PresetID { get; set; }
    }
}
