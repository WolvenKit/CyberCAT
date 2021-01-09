using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AIbehaviorWorkspotList")]
    public class AIbehaviorWorkspotList : IScriptable
    {
        [RealName("spots")]
        [RealType("NodeRef")]
        public string[] Spots { get; set; }
    }
}
