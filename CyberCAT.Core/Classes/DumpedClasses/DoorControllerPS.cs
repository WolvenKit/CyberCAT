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
        [RealType("Bool")]
        public bool IsOpened { get; set; }
        
        [RealName("isLocked")]
        [RealType("Bool")]
        public bool IsLocked { get; set; }
        
        [RealName("isSealed")]
        [RealType("Bool")]
        public bool IsSealed { get; set; }
        
        [RealName("alarmRaised")]
        [RealType("Bool")]
        public bool AlarmRaised { get; set; }
        
        [RealName("isBusy")]
        [RealType("Bool")]
        public bool IsBusy { get; set; }
        
        [RealName("isLiftDoor")]
        [RealType("Bool")]
        public bool IsLiftDoor { get; set; }
        
        [RealName("isPlayerAuthorised")]
        [RealType("Bool")]
        public bool IsPlayerAuthorised { get; set; }
        
        [RealName("openingTokens")]
        public EntEntityID[] OpeningTokens { get; set; }

        public DoorControllerPS()
        {
            AutoToggleQuestMark = true;
        }
    }
}
