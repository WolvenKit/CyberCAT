using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameAttitudeAgentPS")]
    public class GameAttitudeAgentPS : GameComponentPS
    {
        [RealName("currentAttitudeGroup")]
        public CName CurrentAttitudeGroup { get; set; }
    }
}
