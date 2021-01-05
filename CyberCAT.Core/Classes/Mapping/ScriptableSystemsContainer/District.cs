
namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("District")]
    public class District : IScriptable
    {
        [RealName("districtID")]
        [RealType("TweakDBID")]
        public ulong DistrictID { get; set; }
        
        [RealName("presetID")]
        [RealType("TweakDBID")]
        public ulong PresetID { get; set; }
    }
}
