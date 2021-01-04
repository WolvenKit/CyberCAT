using CyberCAT.Core.Classes.Mapping.Global;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.StatPoolsSystem
{
    [RealName("gameStatPoolsSystemSave")]
    public class GameStatPoolsSystemSave : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("mapping")]
        public GameStatsObjectID[] Mapping { get; set; }
        
        [RealName("statPools")]
        public GameStatPoolData[] StatPools { get; set; }
        
    }
}
