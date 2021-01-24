using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("TVControllerPS")]
    public class TVControllerPS : MediaDeviceControllerPS
    {
        [RealName("tvSetup")]
        public TVSetup TvSetup { get; set; }
        
        [RealName("defaultGlitchVideoPath")]
        public RedResourceReferenceScriptToken DefaultGlitchVideoPath { get; set; }
        
        [RealName("broadcastGlitchVideoPath")]
        public RedResourceReferenceScriptToken BroadcastGlitchVideoPath { get; set; }
        
        [RealName("globalTVInitialized")]
        public bool GlobalTVInitialized { get; set; }
        
        [RealName("backupCustomChannels")]
        public STvChannel[] BackupCustomChannels { get; set; }

        public TVControllerPS()
        {
            AutoToggleQuestMark = true;
            IsInteractive = true;
        }
    }
}
