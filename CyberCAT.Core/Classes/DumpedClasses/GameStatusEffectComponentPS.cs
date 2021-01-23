using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameStatusEffectComponentPS")]
    public class GameStatusEffectComponentPS : GameComponentPS
    {
        [RealName("statusEffectArray")]
        public GameStatusEffect[] StatusEffectArray { get; set; }
        
        [RealName("delayedFunctions")]
        public Handle<GameDelayedFunctionsScheduler> DelayedFunctions { get; set; }
        
        [RealName("delayedFunctionsNoTd")]
        public Handle<GameDelayedFunctionsScheduler> DelayedFunctionsNoTd { get; set; }
        
        [RealName("isPlayerControlled")]
        public bool IsPlayerControlled { get; set; }
        
        [RealName("tickComponent")]
        public bool TickComponent { get; set; }
    }
}
