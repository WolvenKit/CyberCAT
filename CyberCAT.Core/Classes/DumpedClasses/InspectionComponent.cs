using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("InspectionComponent")]
    public class InspectionComponent : GameScriptableComponent
    {
        [RealName("slot")]
        public string Slot { get; set; }
        
        [RealName("cumulatedObjRotationX")]
        public float CumulatedObjRotationX { get; set; }
        
        [RealName("cumulatedObjRotationY")]
        public float CumulatedObjRotationY { get; set; }
        
        [RealName("maxObjOffset")]
        public float MaxObjOffset { get; set; }
        
        [RealName("minObjOffset")]
        public float MinObjOffset { get; set; }
        
        [RealName("zoomSpeed")]
        public float ZoomSpeed { get; set; }
        
        [RealName("timeToScan")]
        public float TimeToScan { get; set; }
        
        [RealName("isPlayerInspecting")]
        public bool IsPlayerInspecting { get; set; }
        
        [RealName("activeClue")]
        public string ActiveClue { get; set; }
        
        [RealName("isScanAvailable")]
        public bool IsScanAvailable { get; set; }
        
        [RealName("scanningInProgress")]
        public bool ScanningInProgress { get; set; }
        
        [RealName("objectScanned")]
        public bool ObjectScanned { get; set; }
        
        [RealName("animFeature")]
        public Handle<AnimFeature_Inspection> AnimFeature { get; set; }
        
        [RealName("listener")]
        public Handle<IScriptable> Listener { get; set; }
        
        [RealName("lastInspectedObjID")]
        public EntEntityID LastInspectedObjID { get; set; }
    }
}
