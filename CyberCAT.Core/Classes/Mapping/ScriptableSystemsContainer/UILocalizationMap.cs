
namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("UILocalizationMap")]
    public class UILocalizationMap : IScriptable
    {
        [RealName("map")]
        public UILocRecord[] Map { get; set; }
    }
}
