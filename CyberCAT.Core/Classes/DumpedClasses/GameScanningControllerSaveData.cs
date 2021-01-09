using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameScanningControllerSaveData")]
    public class GameScanningControllerSaveData : ISerializable
    {
        [RealName("taggedObjectIDs")]
        public EntEntityID[] TaggedObjectIDs { get; set; }
    }
}
