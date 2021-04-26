using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameScanningTooltipElementDef")]
    public class GameScanningTooltipElementDef : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("recordID")]
        public TweakDbId RecordID { get; set; }
        
        [RealName("timePct")]
        public float TimePct { get; set; }
    }
}
