using CyberCAT.Core.Classes.Mapping.Global;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
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
