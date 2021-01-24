using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DisposalDeviceControllerPS")]
    public class DisposalDeviceControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("DisposalDeviceSetup")]
        public DisposalDeviceSetup DisposalDeviceSetup { get; set; }
        
        [RealName("distractionSetup")]
        public DistractionSetup DistractionSetup { get; set; }
        
        [RealName("explosionSetup")]
        public DistractionSetup ExplosionSetup { get; set; }
        
        [RealName("isDistractionDisabled")]
        public bool IsDistractionDisabled { get; set; }
        
        [RealName("wasActivated")]
        public bool WasActivated { get; set; }
        
        [RealName("wasLethalTakedownPerformed")]
        public bool WasLethalTakedownPerformed { get; set; }
        
        [RealName("isPlayerCurrentlyPerformingDisposal")]
        public bool IsPlayerCurrentlyPerformingDisposal { get; set; }
    }
}
