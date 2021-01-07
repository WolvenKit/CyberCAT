using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("GameplaySettingsSystem")]
    public class GameplaySettingsSystem : GameScriptableSystem
    {
        [RealName("gameplaySettingsListener")]
        public Handle<GameplaySettingsListener> GameplaySettingsListener { get; set; }
        
        [RealName("wasEverJohnny")]
        [RealType("Bool")]
        public bool WasEverJohnny { get; set; }
    }
}
