using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameStatusEffect")]
    public class GameStatusEffect : GameStatusEffectBase
    {
        [RealName("durationID")]
        public uint DurationID { get; set; }

        [RealName("durationModifiers")]
        public Handle<GameStatModifierData>[] DurationModifiers { get; set; }
        
        [RealName("stackModifiers")]
        public Handle<GameStatModifierData>[] StackModifiers { get; set; }
        
        [RealName("removeAllStacksWhenDurationEndsModifiers")]
        public Handle<GameStatModifierData>[] RemoveAllStacksWhenDurationEndsModifiers { get; set; }

        [RealName("duration")]
        public float Duration { get; set; }

        [RealName("remainingDuration")]
        public float RemainingDuration { get; set; }

        [RealName("maxStacks")]
        public uint MaxStacks { get; set; }
        
        [RealName("sourcesData")]
        public GameSourceData[] SourcesData { get; set; }
        
        [RealName("initialApplicationTimestamp")]
        public float InitialApplicationTimestamp { get; set; }
        
        [RealName("lastApplicationTimestamp")]
        public float LastApplicationTimestamp { get; set; }

        [RealName("ownerEntityID")]
        public EntEntityID OwnerEntityID { get; set; }

        [RealName("instigatorRecordID")]
        public TweakDbId InstigatorRecordID { get; set; }

        [RealName("instigatorEntityID")]
        public EntEntityID InstigatorEntityID { get; set; }
        
        [RealName("direction")]
        public Vector4 Direction { get; set; }
        
        [RealName("removeAllStacksWhenDurationEnds")]
        public bool RemoveAllStacksWhenDurationEnds { get; set; }
        
        [RealName("applicationSource")]
        public CName ApplicationSource { get; set; }

        public GameStatusEffect()
        {
            // TODO: Verify this
            Duration = 1F;
        }
    }
}
