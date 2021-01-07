using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameEffectSet")]
    public class GameEffectSet : CResource
    {
        [RealName("effects")]
        public GameEffectDefinition[] Effects { get; set; }
    }
}
