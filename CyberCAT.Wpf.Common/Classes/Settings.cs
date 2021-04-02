using CyberCAT.Core.Classes;

namespace CyberCAT.Wpf.Common.Classes
{
    public class Settings
    {
        public static Settings Default => new()
        {
            EnabledParsers = SaveFile.ParserList.Enhanced,
            StartInSavesFolder = true,
            QuickActionDebuggingPort = 9222
        };

        public SaveFile.ParserList EnabledParsers { get; set; }
        public bool StartInSavesFolder { get; set; }
        public bool AllowQuickActions { get; set; }
        public bool EnableQuickActionDebugging { get; set; }
        public int QuickActionDebuggingPort { get; set; }
        public Settings()
        {
        }
    }
}
