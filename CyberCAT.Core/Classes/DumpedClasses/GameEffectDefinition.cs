using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameEffectDefinition")]
    public class GameEffectDefinition : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("tag")]
        public CName Tag { get; set; }
        
        [RealName("objectProviders")]
        public Handle<GameEffectObjectProvider>[] ObjectProviders { get; set; }
        
        [RealName("objectFilters")]
        public Handle<GameEffectObjectFilter>[] ObjectFilters { get; set; }
        
        [RealName("effectExecutors")]
        public Handle<GameEffectExecutor>[] EffectExecutors { get; set; }
        
        [RealName("durationModifiers")]
        public Handle<GameEffectDurationModifier>[] DurationModifiers { get; set; }
        
        [RealName("preActions")]
        public Handle<GameEffectPreAction>[] PreActions { get; set; }
        
        [RealName("postActions")]
        public Handle<GameEffectPostAction>[] PostActions { get; set; }
        
        [RealName("noTargetsActions")]
        public Handle<GameEffectAction>[] NoTargetsActions { get; set; }
        
        [RealName("settings")]
        public GameEffectSettings Settings { get; set; }
        
        [RealName("debugSettings")]
        public GameEffectDebugSettings DebugSettings { get; set; }
    }
}
