using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SensorDeviceControllerPS")]
    public class SensorDeviceControllerPS : ExplosiveDeviceControllerPS
    {
        [RealName("isRecognizableBySenses")]
        public bool IsRecognizableBySenses { get; set; }
        
        [RealName("targetingBehaviour")]
        public TargetingBehaviour TargetingBehaviour { get; set; }
        
        [RealName("detectionParameters")]
        public DetectionParameters DetectionParameters { get; set; }
        
        [RealName("lookAtPresetVert")]
        public TweakDbId LookAtPresetVert { get; set; }
        
        [RealName("lookAtPresetHor")]
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
        public bool CanTagEnemies { get; set; }
        
        [RealName("tagLockFromSystem")]
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
        public bool IsInFollowMode { get; set; }
        
        [RealName("isAttitudeChanged")]
        public bool IsAttitudeChanged { get; set; }
        
        [RealName("isInTagKillMode")]
        public bool IsInTagKillMode { get; set; }
        
        [RealName("isIdleForced")]
        public bool IsIdleForced { get; set; }
        
        [RealName("questTargetToSpot")]
        public EntEntityID QuestTargetToSpot { get; set; }
        
        [RealName("questTargetSpotted")]
        public bool QuestTargetSpotted { get; set; }
        
        [RealName("isAnyTargetIsLocked")]
        public bool IsAnyTargetIsLocked { get; set; }
        
        [RealName("isPartOfPrevention")]
        public bool IsPartOfPrevention { get; set; }
    }
}
