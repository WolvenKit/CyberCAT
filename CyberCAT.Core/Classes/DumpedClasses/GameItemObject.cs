using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameItemObject")]
    public class GameItemObject : GameTimeDilatable
    {
        [RealName("lootQuality")]
        public DumpedEnums.gamedataQuality? LootQuality { get; set; }
        
        [RealName("isIconic")]
        public bool IsIconic { get; set; }
        
        [RealName("updateBucket")]
        public DumpedEnums.UpdateBucketEnum? UpdateBucket { get; set; }
    }
}
