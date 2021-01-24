using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("TerminalControllerPS")]
    public class TerminalControllerPS : MasterControllerPS
    {
        [RealName("terminalSetup")]
        public TerminalSetup TerminalSetup { get; set; }
        
        [RealName("terminalSkillChecks")]
        public Handle<HackEngContainer> TerminalSkillChecks { get; set; }
        
        [RealName("spawnedSystems")]
        public Handle<VirtualSystemPS>[] SpawnedSystems { get; set; }
        
        [RealName("useKeyloggerHack")]
        public bool UseKeyloggerHack { get; set; }
        
        [RealName("shouldShowTerminalTitle")]
        public bool ShouldShowTerminalTitle { get; set; }
        
        [RealName("defaultGlitchVideoPath")]
        public RedResourceReferenceScriptToken DefaultGlitchVideoPath { get; set; }
        
        [RealName("broadcastGlitchVideoPath")]
        public RedResourceReferenceScriptToken BroadcastGlitchVideoPath { get; set; }
        
        [RealName("state")]
        public DumpedEnums.gameinteractionsReactionState? State { get; set; }
        
        [RealName("forcedElevatorArrowsState")]
        public DumpedEnums.EForcedElevatorArrowsState? ForcedElevatorArrowsState { get; set; }
    }
}
