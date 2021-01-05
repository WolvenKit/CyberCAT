using CyberCAT.Core.Classes.Mapping.Global;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("GameplaySettingsListener")]
    public class GameplaySettingsListener : UserSettingsVarListener
    {
        [RealName("userSettings")]
        public Handle<UserSettingsUserSettings> UserSettings { get; set; }
        
        [RealName("diffSettingsGroup")]
        public Handle<UserSettingsGroup> DiffSettingsGroup { get; set; }
        
        [RealName("miscSettingsGroup")]
        public Handle<UserSettingsGroup> MiscSettingsGroup { get; set; }
        
        [RealName("additiveCameraMovements")]
        [RealType("Float")]
        public float AdditiveCameraMovements { get; set; }
        
        [RealName("isFastForwardByLine")]
        [RealType("Bool")]
        public bool IsFastForwardByLine { get; set; }
        
        [RealName("additiveCameraGroupName")]
        [RealType("String")]
        public string AdditiveCameraGroupName { get; set; }
        
        [RealName("fastForwardGroupName")]
        [RealType("String")]
        public string FastForwardGroupName { get; set; }
        
        [RealName("difficultyPath")]
        [RealType("String")]
        public string DifficultyPath { get; set; }
        
        [RealName("miscPath")]
        [RealType("String")]
        public string MiscPath { get; set; }
    }
}
