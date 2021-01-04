using CyberCAT.Core.Classes.Mapping.Global;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScanningContoller
{
    [RealName("gameScanningControllerSaveData")]
    public class GameScanningControllerSaveData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("taggedObjectIDs")]
        public EntEntityID[] TaggedObjectIDs { get; set; }
    }
}