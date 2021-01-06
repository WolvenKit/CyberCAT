
namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
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
