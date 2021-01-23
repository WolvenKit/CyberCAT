using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ComputerControllerPS")]
    public class ComputerControllerPS : TerminalControllerPS
    {
        [RealName("computerSetup")]
        public ComputerSetup ComputerSetup { get; set; }
        
        [RealName("quickHackSetup")]
        public ComputerQuickHackData QuickHackSetup { get; set; }
        
        [RealName("activatorActionSetup")]
        public DumpedEnums.EToggleActivationTypeComputer? ActivatorActionSetup { get; set; }
        
        [RealName("computerSkillChecks")]
        public Handle<HackEngContainer> ComputerSkillChecks { get; set; }
        
        [RealName("openedMailAdress")]
        public SDocumentAdress OpenedMailAdress { get; set; }
        
        [RealName("openedFileAdress")]
        public SDocumentAdress OpenedFileAdress { get; set; }
        
        [RealName("quickhackPerformed")]
        public bool QuickhackPerformed { get; set; }
        
        [RealName("isInSleepMode")]
        public bool IsInSleepMode { get; set; }

        public ComputerControllerPS()
        {
            AutoToggleQuestMark = true;
            IsInteractive = true;
        }
    }
}
