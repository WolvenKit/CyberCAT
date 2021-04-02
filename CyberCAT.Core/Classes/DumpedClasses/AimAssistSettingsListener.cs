using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AimAssistSettingsListener")]
    public class AimAssistSettingsListener : UserSettingsVarListener
    {
        [RealName("ctrl")]
        public PlayerPuppet Ctrl { get; set; }
        
        [RealName("settings")]
        public Handle<UserSettingsUserSettings> Settings { get; set; }
        
        [RealName("settingsGroup")]
        public Handle<UserSettingsGroup> SettingsGroup { get; set; }
        
        [RealName("aimAssistLevel")]
        public DumpedEnums.EAimAssistLevel? AimAssistLevel { get; set; }
        
        [RealName("aimAssistMeleeLevel")]
        public DumpedEnums.EAimAssistLevel? AimAssistMeleeLevel { get; set; }
        
        [RealName("currentConfigString")]
        public string CurrentConfigString { get; set; }
        
        [RealName("settingsRecord")]
        public Handle<GamedataAimAssistSettings_Record> SettingsRecord { get; set; }
    }
}
