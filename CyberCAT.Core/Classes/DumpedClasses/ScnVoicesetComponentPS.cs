using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("scnVoicesetComponentPS")]
    public class ScnVoicesetComponentPS : GameComponentPS
    {
        [RealName("blockedInputs")]
        public EntVoicesetInputToBlock[] BlockedInputs { get; set; }
        
        [RealName("voiceTag")]
        [RealType("CName")]
        public string VoiceTag { get; set; }
        
        [RealName("NPCHighLevelState")]
        public DumpedEnums.gamedataNPCHighLevelState? NPCHighLevelState { get; set; }
        
        [RealName("gruntSetIndex")]
        [RealType("Uint32")]
        public uint GruntSetIndex { get; set; }
        
        [RealName("areVoicesetLinesEnabled")]
        [RealType("Bool")]
        public bool AreVoicesetLinesEnabled { get; set; }
        
        [RealName("areVoicesetGruntsEnabled")]
        [RealType("Bool")]
        public bool AreVoicesetGruntsEnabled { get; set; }
    }
}
