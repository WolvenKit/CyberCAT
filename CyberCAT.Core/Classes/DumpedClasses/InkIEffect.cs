using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("inkIEffect")]
    public class InkIEffect : ISerializable
    {
        [RealName("isEnabled")]
        public bool IsEnabled { get; set; }
        
        [RealName("effectName")]
        public CName EffectName { get; set; }
    }
}
