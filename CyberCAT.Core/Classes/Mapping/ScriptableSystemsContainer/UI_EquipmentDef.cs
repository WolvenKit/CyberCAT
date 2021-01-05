
namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("UI_EquipmentDef")]
    public class UI_EquipmentDef : GamebbScriptDefinition
    {
        [RealName("itemEquipped")]
        public GamebbScriptID_Variant ItemEquipped { get; set; }
        
        [RealName("lastModifiedArea")]
        public GamebbScriptID_Variant LastModifiedArea { get; set; }
    }
}
