using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("GameplaySettingsListener")]
    public class GameplaySettingsListener : UserSettingsVarListener
    {
        [RealName("player")]
        public PlayerPuppet Player { get; set; }
        
        [RealName("userSettings")]
        public Handle<UserSettingsUserSettings> UserSettings { get; set; }
        
        [RealName("diffSettingsGroup")]
        public Handle<UserSettingsGroup> DiffSettingsGroup { get; set; }
        
        [RealName("miscSettingsGroup")]
        public Handle<UserSettingsGroup> MiscSettingsGroup { get; set; }
        
        [RealName("controlsGroup")]
        public Handle<UserSettingsGroup> ControlsGroup { get; set; }
        
        [RealName("additiveCameraMovements")]
        public float AdditiveCameraMovements { get; set; }
        
        [RealName("isFastForwardByLine")]
        public bool IsFastForwardByLine { get; set; }
        
        [RealName("movementDodgeEnabled")]
        public bool MovementDodgeEnabled { get; set; }
        
        [RealName("additiveCameraGroupName")]
        public string AdditiveCameraGroupName { get; set; }
        
        [RealName("fastForwardGroupName")]
        public string FastForwardGroupName { get; set; }
        
        [RealName("movementDodgeGroupName")]
        public string MovementDodgeGroupName { get; set; }
        
        [RealName("difficultyPath")]
        public string DifficultyPath { get; set; }
        
        [RealName("miscPath")]
        public string MiscPath { get; set; }
        
        [RealName("controlsPath")]
        public string ControlsPath { get; set; }
    }
}
