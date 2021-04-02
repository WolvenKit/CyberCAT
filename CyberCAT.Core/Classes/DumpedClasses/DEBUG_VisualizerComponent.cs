using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DEBUG_VisualizerComponent")]
    public class DEBUG_VisualizerComponent : GameScriptableComponent
    {
        [RealName("records")]
        public DEBUG_VisualRecord[] Records { get; set; }
        
        [RealName("offsetCounter")]
        public int OffsetCounter { get; set; }
        
        [RealName("timeToNextUpdate")]
        public float TimeToNextUpdate { get; set; }
        
        [RealName("processedRecordIndex")]
        public int ProcessedRecordIndex { get; set; }
        
        [RealName("showWeaponsStreaming")]
        public bool ShowWeaponsStreaming { get; set; }
        
        [RealName("TICK_TIME_DELTA")]
        public float TICK_TIME_DELTA { get; set; }
        
        [RealName("TEXT_SCALE_NAME")]
        public float TEXT_SCALE_NAME { get; set; }
        
        [RealName("TEXT_SCALE_ATTITUDE")]
        public float TEXT_SCALE_ATTITUDE { get; set; }
        
        [RealName("TEXT_SCALE_IMMORTALITY_MODE")]
        public float TEXT_SCALE_IMMORTALITY_MODE { get; set; }
        
        [RealName("TEXT_TOP")]
        public float TEXT_TOP { get; set; }
        
        [RealName("TEXT_OFFSET")]
        public float TEXT_OFFSET { get; set; }
    }
}
