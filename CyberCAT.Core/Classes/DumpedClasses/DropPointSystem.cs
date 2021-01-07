using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
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
