using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AccessPointControllerPS")]
    public class AccessPointControllerPS : MasterControllerPS
    {
        [RealName("rewardNotificationIcons")]
        public string[] RewardNotificationIcons { get; set; }
        
        [RealName("rewardNotificationString")]
        public string RewardNotificationString { get; set; }
        
        [RealName("accessPointSkillChecks")]
        public Handle<HackingContainer> AccessPointSkillChecks { get; set; }
        
        [RealName("isBreached")]
        public bool IsBreached { get; set; }
        
        [RealName("isVirtual")]
        public bool IsVirtual { get; set; }
    }
}
