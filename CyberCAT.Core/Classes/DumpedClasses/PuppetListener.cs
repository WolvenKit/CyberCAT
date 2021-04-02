using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("PuppetListener")]
    public class PuppetListener : IScriptable
    {
        [RealName("prereqOwner")]
        public Handle<GamePrereqState> PrereqOwner { get; set; }
    }
}
