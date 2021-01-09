using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("PlayerPuppetPS")]
    public class PlayerPuppetPS : ScriptedPuppetPS
    {
        [RealName("keybindigs")]
        public KeyBindings Keybindigs { get; set; }
        
        [RealName("availablePrograms")]
        public GameuiMinigameProgramData[] AvailablePrograms { get; set; }
        
        [RealName("hasAutoReveal")]
        [RealType("Bool")]
        public bool HasAutoReveal { get; set; }
        
        [RealName("minigameBB")]
        public Handle<GameIBlackboard> MinigameBB { get; set; }
    }
}
