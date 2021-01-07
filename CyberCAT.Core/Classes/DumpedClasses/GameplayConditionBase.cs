using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("GameplayConditionBase")]
    public class GameplayConditionBase : IScriptable
    {
        [RealName("entityID")]
        public EntEntityID EntityID { get; set; }
    }
}
