using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AIHumanComponent")]
    public class AIHumanComponent : AICAgent
    {
        [RealName("shootingBlackboard")]
        public Handle<GameIBlackboard> ShootingBlackboard { get; set; }
        
        [RealName("gadgetBlackboard")]
        public Handle<GameIBlackboard> GadgetBlackboard { get; set; }
        
        [RealName("coverBlackboard")]
        public Handle<GameIBlackboard> CoverBlackboard { get; set; }
        
        [RealName("actionBlackboard")]
        public Handle<GameIBlackboard> ActionBlackboard { get; set; }
        
        [RealName("patrolBlackboard")]
        public Handle<GameIBlackboard> PatrolBlackboard { get; set; }
        
        [RealName("alertedPatrolBlackboard")]
        public Handle<GameIBlackboard> AlertedPatrolBlackboard { get; set; }
        
        [RealName("friendlyFireCheckID")]
        public uint FriendlyFireCheckID { get; set; }
        
        [RealName("ffs")]
        public Handle<GameIFriendlyFireSystem> Ffs { get; set; }
        
        [RealName("LoSFinderCheckID")]
        public uint LoSFinderCheckID { get; set; }
        
        [RealName("loSFinderSystem")]
        public Handle<GameLoSIFinderSystem> LoSFinderSystem { get; set; }
        
        [RealName("LoSFinderVisibleObject")]
        public SenseVisibleObject LoSFinderVisibleObject { get; set; }
        
        [RealName("actionAnimationScriptProxy")]
        public Handle<ActionAnimationScriptProxy> ActionAnimationScriptProxy { get; set; }
        
        [RealName("lastOwnerBlockedAttackEventID")]
        public GameDelayID LastOwnerBlockedAttackEventID { get; set; }
        
        [RealName("lastOwnerParriedAttackEventID")]
        public GameDelayID LastOwnerParriedAttackEventID { get; set; }
        
        [RealName("lastOwnerDodgedAttackEventID")]
        public GameDelayID LastOwnerDodgedAttackEventID { get; set; }
        
        [RealName("grenadeThrowQueryTarget")]
        public GameObject GrenadeThrowQueryTarget { get; set; }
        
        [RealName("grenadeThrowQueryId")]
        public int GrenadeThrowQueryId { get; set; }
        
        [RealName("scriptContext")]
        public AIbehaviorScriptExecutionContext ScriptContext { get; set; }
        
        [RealName("scriptContextInitialized")]
        public bool ScriptContextInitialized { get; set; }
        
        [RealName("highLevelCb")]
        public uint HighLevelCb { get; set; }
        
        [RealName("activeCommands")]
        public AIbehaviorUniqueActiveCommandList ActiveCommands { get; set; }
        
        [RealName("movementParamsRecord")]
        public TweakDbId MovementParamsRecord { get; set; }
    }
}
