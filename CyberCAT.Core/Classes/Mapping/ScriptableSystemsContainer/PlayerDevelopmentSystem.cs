using CyberCAT.Core.Classes.Mapping.Global;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
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
