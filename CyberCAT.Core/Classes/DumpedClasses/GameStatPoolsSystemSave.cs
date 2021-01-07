using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameStatPoolsSystemSave")]
    public class GameStatPoolsSystemSave : ISerializable
    {
        [RealName("mapping")]
        public GameStatsObjectID[] Mapping { get; set; }
        
        [RealName("statPools")]
        public GameStatPoolData[] StatPools { get; set; }
    }
}
