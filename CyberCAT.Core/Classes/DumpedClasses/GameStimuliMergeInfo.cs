using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameStimuliMergeInfo")]
    public class GameStimuliMergeInfo : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("position")]
        public Vector4 Position { get; set; }

        [RealName("instigator")]
        public WHandle<GameObject> Instigator { get; set; }

        [RealName("radius")]
        public float Radius { get; set; }

        [RealName("type")]
        public DumpedEnums.gamedataStimType? Type { get; set; }

        [RealName("propagationType")]
        public DumpedEnums.gamedataStimPropagation? PropagationType { get; set; }
    }
}