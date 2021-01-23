using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AIPatrolRole")]
    public class AIPatrolRole : AIRole
    {
        [RealName("pathParams")]
        public Handle<AIPatrolPathParameters> PathParams { get; set; }
        
        [RealName("alertedPathParams")]
        public Handle<AIPatrolPathParameters> AlertedPathParams { get; set; }
        
        [RealName("alertedRadius")]
        public float AlertedRadius { get; set; }
        
        [RealName("alertedSpots")]
        public Handle<AIbehaviorWorkspotList> AlertedSpots { get; set; }
        
        [RealName("forceAlerted")]
        public bool ForceAlerted { get; set; }
    }
}
