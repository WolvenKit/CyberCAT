using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("senseStimuliEvent")]
    public class SenseStimuliEvent : SenseBaseStimuliEvent
    {
        [RealName("sourceObject")]
        public WHandle<GameObject> SourceObject { get; set; }

        [RealName("sourcePosition")]
        public Vector4 SourcePosition { get; set; }

        [RealName("stimRecord")]
        public WHandle<GamedataStim_Record> StimRecord { get; set; }

        [RealName("radius")]
        public float Radius { get; set; }

        [RealName("detection")]
        public float Detection { get; set; }

        [RealName("stimType")]
        public DumpedEnums.gamedataStimType? StimType { get; set; }

        [RealName("stimPropagation")]
        public DumpedEnums.gamedataStimPropagation? StimPropagation { get; set; }

        [RealName("data")]
        public Handle<SenseStimuliData> Data { get; set; }

        [RealName("id")]
        public uint Id { get; set; }

        [RealName("movePositions")]
        public Vector4[] MovePositions { get; set; }

        [RealName("stimInvestigateData")]
        public StimInvestigateData StimInvestigateData { get; set; }
    }
}
