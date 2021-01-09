using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("UI_ItemModSystemDef")]
    public class UI_ItemModSystemDef : GamebbScriptDefinition
    {
        [RealName("ItemModSystemUpdated")]
        public GamebbScriptID_Variant ItemModSystemUpdated { get; set; }
    }
}
