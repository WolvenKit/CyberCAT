using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.StatsSystem
{
    [RealName("gameStatsStateMapStructure")]
    public class GameStatsStateMapStructure : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("keys")]
        public GameStatsObjectID[] Keys { get; set; }

        [RealName("values")]
        public GameSavedStatsData[] Values { get; set; }
    }
}