using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.Global
{
    [RealName("gameStatsObjectID")]
    public class GameStatsObjectID : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("entityHash")]
        [RealType("Uint64")]
        public ulong EntityHash { get; set; }

        [RealName("idType")]
        public DumpedEnums.gameStatIDType? IdType { get; set; }
    }
}