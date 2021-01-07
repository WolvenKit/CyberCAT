using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AccessPointControllerPS")]
    public class AccessPointControllerPS : MasterControllerPS
    {
        [RealName("rewardNotificationIcons")]
        [RealType("String")]
        public string[] RewardNotificationIcons { get; set; }
        
        [RealName("rewardNotificationString")]
        [RealType("String")]
        public string RewardNotificationString { get; set; }
        
        [RealName("accessPointSkillChecks")]
        public Handle<HackingContainer> AccessPointSkillChecks { get; set; }
        
        [RealName("isBreached")]
        [RealType("Bool")]
        public bool IsBreached { get; set; }
        
        [RealName("isVirtual")]
        [RealType("Bool")]
        public bool IsVirtual { get; set; }
    }
}
