using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
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
