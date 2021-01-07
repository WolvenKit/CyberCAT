using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameStatusEffect")]
    public class GameStatusEffect : GameStatusEffectBase
    {
        [RealName("durationID")]
        [RealType("Uint32")]
        public uint DurationID { get; set; }
        
        [RealName("durationModifiers")]
        public Handle<GameStatModifierData>[] DurationModifiers { get; set; }
        
        [RealName("stackModifiers")]
        public Handle<GameStatModifierData>[] StackModifiers { get; set; }
        
        [RealName("removeAllStacksWhenDurationEndsModifiers")]
        public Handle<GameStatModifierData>[] RemoveAllStacksWhenDurationEndsModifiers { get; set; }
        
        [RealName("duration")]
        [RealType("Float")]
        public float Duration { get; set; }
        
        [RealName("remainingDuration")]
        [RealType("Float")]
        public float RemainingDuration { get; set; }
        
        [RealName("maxStacks")]
        [RealType("Uint32")]
        public uint MaxStacks { get; set; }
        
        [RealName("sourcesData")]
        public GameSourceData[] SourcesData { get; set; }
        
        [RealName("initialApplicationTimestamp")]
        [RealType("Float")]
        public float InitialApplicationTimestamp { get; set; }
        
        [RealName("lastApplicationTimestamp")]
        [RealType("Float")]
        public float LastApplicationTimestamp { get; set; }
        
        [RealName("ownerEntityID")]
        public EntEntityID OwnerEntityID { get; set; }
        
        [RealName("instigatorRecordID")]
        [RealType("TweakDBID")]
        public TweakDbId InstigatorRecordID { get; set; }
        
        [RealName("instigatorEntityID")]
        public EntEntityID InstigatorEntityID { get; set; }
        
        [RealName("direction")]
        public Vector4 Direction { get; set; }
        
        [RealName("removeAllStacksWhenDurationEnds")]
        [RealType("Bool")]
        public bool RemoveAllStacksWhenDurationEnds { get; set; }
        
        [RealName("applicationSource")]
        [RealType("CName")]
        public string ApplicationSource { get; set; }
    }
}
