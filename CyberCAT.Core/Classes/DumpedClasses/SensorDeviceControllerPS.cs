using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SensorDeviceControllerPS")]
    public class SensorDeviceControllerPS : ExplosiveDeviceControllerPS
    {
        [RealName("isRecognizableBySenses")]
        [RealType("Bool")]
        public bool IsRecognizableBySenses { get; set; }
        
        [RealName("targetingBehaviour")]
        public TargetingBehaviour TargetingBehaviour { get; set; }
        
        [RealName("detectionParameters")]
        public DetectionParameters DetectionParameters { get; set; }
        
        [RealName("lookAtPresetVert")]
        [RealType("TweakDBID")]
        public TweakDbId LookAtPresetVert { get; set; }
        
        [RealName("lookAtPresetHor")]
        [RealType("TweakDBID")]
        public TweakDbId LookAtPresetHor { get; set; }
        
        [RealName("scanGameEffectRef")]
        public GameEffectRef ScanGameEffectRef { get; set; }
        
        [RealName("visionConeEffectRef")]
        public GameEffectRef VisionConeEffectRef { get; set; }
        
        [RealName("visionConeFriendlyEffectRef")]
        public GameEffectRef VisionConeFriendlyEffectRef { get; set; }
        
        [RealName("idleActiveRef")]
        public GameEffectRef IdleActiveRef { get; set; }
        
        [RealName("idleFriendlyRef")]
        public GameEffectRef IdleFriendlyRef { get; set; }
        
        [RealName("canTagEnemies")]
        [RealType("Bool")]
        public bool CanTagEnemies { get; set; }
        
        [RealName("tagLockFromSystem")]
        [RealType("Bool")]
        public bool TagLockFromSystem { get; set; }
        
        [RealName("netrunnerID")]
        public EntEntityID NetrunnerID { get; set; }
        
        [RealName("netrunnerProxyID")]
        public EntEntityID NetrunnerProxyID { get; set; }
        
        [RealName("netrunnerTargetID")]
        public EntEntityID NetrunnerTargetID { get; set; }
        
        [RealName("linkedStatusEffect")]
        public LinkedStatusEffect LinkedStatusEffect { get; set; }
        
        [RealName("questForcedTargetID")]
        public EntEntityID QuestForcedTargetID { get; set; }
        
        [RealName("isInFollowMode")]
        [RealType("Bool")]
        public bool IsInFollowMode { get; set; }
        
        [RealName("isAttitudeChanged")]
        [RealType("Bool")]
        public bool IsAttitudeChanged { get; set; }
        
        [RealName("isInTagKillMode")]
        [RealType("Bool")]
        public bool IsInTagKillMode { get; set; }
        
        [RealName("isIdleForced")]
        [RealType("Bool")]
        public bool IsIdleForced { get; set; }
        
        [RealName("questTargetToSpot")]
        public EntEntityID QuestTargetToSpot { get; set; }
        
        [RealName("questTargetSpotted")]
        [RealType("Bool")]
        public bool QuestTargetSpotted { get; set; }
        
        [RealName("isAnyTargetIsLocked")]
        [RealType("Bool")]
        public bool IsAnyTargetIsLocked { get; set; }
        
        [RealName("isPartOfPrevention")]
        [RealType("Bool")]
        public bool IsPartOfPrevention { get; set; }
    }
}
