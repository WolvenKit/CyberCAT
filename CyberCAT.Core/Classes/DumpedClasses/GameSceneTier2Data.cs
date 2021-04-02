using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameSceneTier2Data")]
    public class GameSceneTier2Data : GameSceneTierData
    {
        [RealName("walkType")]
        public DumpedEnums.Tier2WalkType? WalkType { get; set; }
    }
}
