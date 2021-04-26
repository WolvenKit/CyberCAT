using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameeventsStatusEffectEvent")]
    public class GameeventsStatusEffectEvent : RedEvent
    {
        [RealName("staticData")]
        public Handle<GamedataStatusEffect_Record> StaticData { get; set; }
        
        [RealName("stackCount")]
        public uint StackCount { get; set; }
    }
}
