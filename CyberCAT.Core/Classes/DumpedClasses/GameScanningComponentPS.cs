using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameScanningComponentPS")]
    public class GameScanningComponentPS : GameComponentPS
    {
        [RealName("scanningState")]
        public DumpedEnums.gameScanningState? ScanningState { get; set; }
        
        [RealName("pctScanned")]
        [RealType("Float")]
        public float PctScanned { get; set; }
        
        [RealName("isBlocked")]
        [RealType("Bool")]
        public bool IsBlocked { get; set; }
        
        [RealName("storedClues")]
        public Handle<CluePSData>[] StoredClues { get; set; }
        
        [RealName("isScanningDisabled")]
        [RealType("Bool")]
        public bool IsScanningDisabled { get; set; }
        
        [RealName("isDecriptionEnabled")]
        [RealType("Bool")]
        public bool IsDecriptionEnabled { get; set; }
        
        [RealName("objectDescriptionOverride")]
        public Handle<ObjectScanningDescription> ObjectDescriptionOverride { get; set; }
    }
}
