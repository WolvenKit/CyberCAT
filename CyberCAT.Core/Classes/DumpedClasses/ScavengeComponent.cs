using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ScavengeComponent")]
    public class ScavengeComponent : GameScriptableComponent
    {
        [RealName("scavengeTargets")]
        public GameObject[] ScavengeTargets { get; set; }
    }
}
