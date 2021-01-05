
using CyberCAT.Core.Classes.Mapping.Global;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("GameplayConditionBase")]
    public class GameplayConditionBase : IScriptable
    {
        [RealName("entityID")]
        public EntEntityID EntityID { get; set; }
    }
}
