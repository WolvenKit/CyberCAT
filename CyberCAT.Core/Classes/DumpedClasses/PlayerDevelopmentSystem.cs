using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("PlayerDevelopmentSystem")]
    public class PlayerDevelopmentSystem : GameScriptableSystem
    {
        [RealName("playerData")]
        public Handle<PlayerDevelopmentData>[] PlayerData { get; set; }
        
        [RealName("ownerData")]
        public Handle<PlayerDevelopmentData>[] OwnerData { get; set; }
    }
}
