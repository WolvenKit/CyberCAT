using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("scnVoicesetComponentPS")]
    public class ScnVoicesetComponentPS : GameComponentPS
    {
        [RealName("blockedInputs")]
        public EntVoicesetInputToBlock[] BlockedInputs { get; set; }
        
        [RealName("voiceTag")]
        public CName VoiceTag { get; set; }
        
        [RealName("NPCHighLevelState")]
        public DumpedEnums.gamedataNPCHighLevelState? NPCHighLevelState { get; set; }
        
        [RealName("gruntSetIndex")]
        public uint GruntSetIndex { get; set; }
        
        [RealName("areVoicesetLinesEnabled")]
        public bool AreVoicesetLinesEnabled { get; set; }
        
        [RealName("areVoicesetGruntsEnabled")]
        public bool AreVoicesetGruntsEnabled { get; set; }

        public ScnVoicesetComponentPS()
        {
            AreVoicesetLinesEnabled = true;
            AreVoicesetGruntsEnabled = true;
        }
    }
}
