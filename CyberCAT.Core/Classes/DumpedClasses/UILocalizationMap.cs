using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("UILocalizationMap")]
    public class UILocalizationMap : IScriptable
    {
        [RealName("map")]
        public UILocRecord[] Map { get; set; }
    }
}
