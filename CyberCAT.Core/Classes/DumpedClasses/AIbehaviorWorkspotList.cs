using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AIbehaviorWorkspotList")]
    public class AIbehaviorWorkspotList : IScriptable
    {
        [RealName("spots")]
        public NodeRef[] Spots { get; set; }
    }
}
