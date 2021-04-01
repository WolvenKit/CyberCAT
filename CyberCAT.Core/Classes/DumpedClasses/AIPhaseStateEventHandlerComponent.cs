using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AIPhaseStateEventHandlerComponent")]
    public class AIPhaseStateEventHandlerComponent : AIRelatedComponents
    {
        [RealName("phaseStateValue")]
        public DumpedEnums.ENPCPhaseState? PhaseStateValue { get; set; }
    }
}
