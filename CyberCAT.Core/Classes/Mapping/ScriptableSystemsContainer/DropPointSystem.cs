using CyberCAT.Core.Classes.Mapping.Global;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("DropPointSystem")]
    public class DropPointSystem : GameScriptableSystem
    {
        [RealName("packages")]
        public Handle<DropPointPackage>[] Packages { get; set; }
        
        [RealName("mappins")]
        public Handle<DropPointMappinRegistrationData>[] Mappins { get; set; }
        
        [RealName("isEnabled")]
        [RealType("Bool")]
        public bool IsEnabled { get; set; }
    }
}
