using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("WindowBlindersControllerPS")]
    public class WindowBlindersControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("windowBlindersSkillChecks")]
        public Handle<EngDemoContainer> WindowBlindersSkillChecks { get; set; }
        
        [RealName("windowBlindersData")]
        public WindowBlindersData WindowBlindersData { get; set; }
        
        [RealName("cachedState")]
        public DumpedEnums.EWindowBlindersStates? CachedState { get; set; }
        
        [RealName("alarmRaised")]
        public bool AlarmRaised { get; set; }
    }
}
