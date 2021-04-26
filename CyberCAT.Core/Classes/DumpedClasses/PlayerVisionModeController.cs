using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("PlayerVisionModeController")]
    public class PlayerVisionModeController : IScriptable
    {
        [RealName("gameplayActiveFlagsRefreshPolicy")]
        public PlayerVisionModeControllerRefreshPolicy GameplayActiveFlagsRefreshPolicy { get; set; }
        
        [RealName("blackboardIds")]
        public PlayerVisionModeControllerBBIds BlackboardIds { get; set; }
        
        [RealName("blackboardValuesIds")]
        public PlayerVisionModeControllerBBValuesIds BlackboardValuesIds { get; set; }
        
        [RealName("blackboardListenersFunctions")]
        public PlayerVisionModeControllerBlackboardListenersFunctions BlackboardListenersFunctions { get; set; }
        
        [RealName("blackboardListeners")]
        public PlayerVisionModeControllerBBListeners BlackboardListeners { get; set; }
        
        [RealName("gameplayActiveFlags")]
        public PlayerVisionModeControllerActiveFlags GameplayActiveFlags { get; set; }
        
        [RealName("inputActionsNames")]
        public PlayerVisionModeControllerInputActionsNames InputActionsNames { get; set; }
        
        [RealName("inputListeners")]
        public PlayerVisionModeControllerInputListeners InputListeners { get; set; }
        
        [RealName("inputActiveFlags")]
        public PlayerVisionModeControllerInputActiveFlags InputActiveFlags { get; set; }
        
        [RealName("otherVars")]
        public PlayerVisionModeControllerOtherVars OtherVars { get; set; }
        
        [RealName("owner")]
        public GameObject Owner { get; set; }
    }
}
