using CyberCAT.Core.Classes;

namespace CyberCAT.Wpf.Classes
{
    public class Settings
    {
        public static Settings Default => new()
        {
            EnabledParsers = SaveFile.ParserList.Enhanced,
            StartInSavesFolder = true
        };

        public SaveFile.ParserList EnabledParsers { get; set; }
        public bool StartInSavesFolder { get; set; }
        public bool AllowQuickActions { get; set; }
        public Settings()
        {
        }
    }
}
