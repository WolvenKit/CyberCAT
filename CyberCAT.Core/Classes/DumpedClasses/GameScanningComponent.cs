using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameScanningComponent")]
    public class GameScanningComponent : GameComponent
    {
        [RealName("isBraindanceClue")]
        public bool IsBraindanceClue { get; set; }
        
        [RealName("BraindanceLayer")]
        public DumpedEnums.braindanceVisionMode? BraindanceLayer { get; set; }
        
        [RealName("isBraindanceBlocked")]
        public bool IsBraindanceBlocked { get; set; }
        
        [RealName("isBraindanceLayerUnlocked")]
        public bool IsBraindanceLayerUnlocked { get; set; }
        
        [RealName("isBraindanceTimelineUnlocked")]
        public bool IsBraindanceTimelineUnlocked { get; set; }
        
        [RealName("isBraindanceActive")]
        public bool IsBraindanceActive { get; set; }
        
        [RealName("currentBraindanceLayer")]
        public int CurrentBraindanceLayer { get; set; }
        
        [RealName("clues")]
        public FocusClueDefinition[] Clues { get; set; }
        
        [RealName("objectDescription")]
        public Handle<ObjectScanningDescription> ObjectDescription { get; set; }
        
        [RealName("scanningBarText")]
        public TweakDbId ScanningBarText { get; set; }
        
        [RealName("isFocusModeActive")]
        public bool IsFocusModeActive { get; set; }
        
        [RealName("currentHighlight")]
        public Handle<FocusForcedHighlightData> CurrentHighlight { get; set; }
        
        [RealName("isHudManagerInitialized")]
        public bool IsHudManagerInitialized { get; set; }
        
        [RealName("isBeingScanned")]
        public bool IsBeingScanned { get; set; }
        
        [RealName("isScanningCluesBlocked")]
        public bool IsScanningCluesBlocked { get; set; }
        
        [RealName("isEntityVisible")]
        public bool IsEntityVisible { get; set; }
        
        [RealName("cpoEnableMultiplePlayersScanningModifier")]
        public bool CpoEnableMultiplePlayersScanningModifier { get; set; }
        
        [RealName("autoGenerateBoundingSphere")]
        public bool AutoGenerateBoundingSphere { get; set; }
        
        [RealName("ignoresScanningDistanceLimit")]
        public bool IgnoresScanningDistanceLimit { get; set; }
        
        [RealName("timeNeeded")]
        public float TimeNeeded { get; set; }
        
        [RealName("boundingSphere")]
        public Sphere BoundingSphere { get; set; }
        
        [RealName("scannableData")]
        public GameScanningTooltipElementDef[] ScannableData { get; set; }
    }
}
