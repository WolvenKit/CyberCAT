using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("worldEffect")]
    public class WorldEffect : ResStreamedResource
    {
        [RealName("name")]
        [RealType("CName")]
        public string Name { get; set; }
        
        [RealName("length")]
        [RealType("Float")]
        public float Length { get; set; }
        
        [RealName("inputParameterNames")]
        [RealType("CName")]
        public string[] InputParameterNames { get; set; }
        
        [RealName("trackRoot")]
        public Handle<EffectTrackGroup> TrackRoot { get; set; }
        
        [RealName("events")]
        public Handle<EffectTrackItem>[] Events { get; set; }
        
        [RealName("effectLoops")]
        public EffectLoopData[] EffectLoops { get; set; }
    }
}
