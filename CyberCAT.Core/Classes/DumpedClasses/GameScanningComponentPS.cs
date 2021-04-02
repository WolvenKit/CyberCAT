using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameScanningComponentPS")]
    public class GameScanningComponentPS : GameComponentPS
    {
        [RealName("storedClues")]
        public Handle<CluePSData>[] StoredClues { get; set; }
        
        [RealName("isScanningDisabled")]
        public bool IsScanningDisabled { get; set; }
        
        [RealName("isDecriptionEnabled")]
        public bool IsDecriptionEnabled { get; set; }
        
        [RealName("objectDescriptionOverride")]
        public Handle<ObjectScanningDescription> ObjectDescriptionOverride { get; set; }
        
        [RealName("scanningState")]
        public DumpedEnums.gameScanningState? ScanningState { get; set; }
        
        [RealName("pctScanned")]
        public float PctScanned { get; set; }
        
        [RealName("isBlocked")]
        public bool IsBlocked { get; set; }
    }
}
