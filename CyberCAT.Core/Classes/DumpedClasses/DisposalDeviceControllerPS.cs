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
        [RealType("Bool")]
        public bool IsDistractionDisabled { get; set; }
        
        [RealName("wasActivated")]
        [RealType("Bool")]
        public bool WasActivated { get; set; }
        
        [RealName("wasLethalTakedownPerformed")]
        [RealType("Bool")]
        public bool WasLethalTakedownPerformed { get; set; }
        
        [RealName("isPlayerCurrentlyPerformingDisposal")]
        [RealType("Bool")]
        public bool IsPlayerCurrentlyPerformingDisposal { get; set; }
    }
}
