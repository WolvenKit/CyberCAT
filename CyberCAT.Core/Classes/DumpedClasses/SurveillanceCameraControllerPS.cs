using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SurveillanceCameraControllerPS")]
    public class SurveillanceCameraControllerPS : SensorDeviceControllerPS
    {
        [RealName("cameraProperties")]
        public CameraSetup CameraProperties { get; set; }
        
        [RealName("cameraQuestProperties")]
        public CameraQuestProperties CameraQuestProperties { get; set; }
        
        [RealName("cameraState")]
        public DumpedEnums.ESurveillanceCameraStatus? CameraState { get; set; }
        
        [RealName("shouldStream")]
        public bool ShouldStream { get; set; }
        
        [RealName("isDetecting")]
        public bool IsDetecting { get; set; }
        
        [RealName("feedReceivers")]
        public EntEntityID[] FeedReceivers { get; set; }
        
        [RealName("mostRecentRequester")]
        public EntEntityID MostRecentRequester { get; set; }
        
        [RealName("virtualComponentName")]
        public CName VirtualComponentName { get; set; }
        
        [RealName("isFeedReplacedWithBink")]
        public bool IsFeedReplacedWithBink { get; set; }
        
        [RealName("binkVideoPath")]
        public RedResourceReferenceScriptToken BinkVideoPath { get; set; }
        
        [RealName("shouldRevealEnemies")]
        public bool ShouldRevealEnemies { get; set; }
        
        [RealName("cameraSkillChecks")]
        public Handle<EngDemoContainer> CameraSkillChecks { get; set; }

        public SurveillanceCameraControllerPS()
        {
            AutoToggleQuestMark = true;
        }
    }
}
