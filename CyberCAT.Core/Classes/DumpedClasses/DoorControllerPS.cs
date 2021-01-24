using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DoorControllerPS")]
    public class DoorControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("doorProperties")]
        public DoorSetup DoorProperties { get; set; }
        
        [RealName("doorSkillChecks")]
        public Handle<EngDemoContainer> DoorSkillChecks { get; set; }
        
        [RealName("isOpened")]
        public bool IsOpened { get; set; }
        
        [RealName("isLocked")]
        public bool IsLocked { get; set; }
        
        [RealName("isSealed")]
        public bool IsSealed { get; set; }
        
        [RealName("alarmRaised")]
        public bool AlarmRaised { get; set; }
        
        [RealName("isBusy")]
        public bool IsBusy { get; set; }
        
        [RealName("isLiftDoor")]
        public bool IsLiftDoor { get; set; }
        
        [RealName("isPlayerAuthorised")]
        public bool IsPlayerAuthorised { get; set; }
        
        [RealName("openingTokens")]
        public EntEntityID[] OpeningTokens { get; set; }

        public DoorControllerPS()
        {
            AutoToggleQuestMark = true;
        }
    }
}
