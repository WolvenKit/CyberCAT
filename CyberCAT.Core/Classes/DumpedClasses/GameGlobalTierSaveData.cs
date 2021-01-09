using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameGlobalTierSaveData")]
    public class GameGlobalTierSaveData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("subtype")]
        public DumpedEnums.gameGlobalTierSubtype? Subtype { get; set; }
        
        [RealName("data")]
        public Handle<GameSceneTierData> Data { get; set; }
    }
}
