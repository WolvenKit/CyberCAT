using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameAttitudeAgentPS")]
    public class GameAttitudeAgentPS : GameComponentPS
    {
        [RealName("currentAttitudeGroup")]
        [RealType("CName")]
        public string CurrentAttitudeGroup { get; set; }
    }
}
