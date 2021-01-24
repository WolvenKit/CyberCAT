using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("VehicleComponentPS")]
    public class VehicleComponentPS : ScriptableDeviceComponentPS
    {
        [RealName("defaultStateSet")]
        public bool DefaultStateSet { get; set; }
        
        [RealName("stateModifiedByQuest")]
        public bool StateModifiedByQuest { get; set; }
        
        [RealName("playerVehicle")]
        public bool PlayerVehicle { get; set; }
        
        [RealName("npcOccupiedSlots")]
        public CName[] NpcOccupiedSlots { get; set; }
        
        [RealName("isDestroyed")]
        public bool IsDestroyed { get; set; }
        
        [RealName("isStolen")]
        public bool IsStolen { get; set; }
        
        [RealName("crystalDomeQuestModified")]
        public bool CrystalDomeQuestModified { get; set; }
        
        [RealName("crystalDomeQuestState")]
        public bool CrystalDomeQuestState { get; set; }
        
        [RealName("crystalDomeState")]
        public bool CrystalDomeState { get; set; }
        
        [RealName("visualDestructionSet")]
        public bool VisualDestructionSet { get; set; }
        
        [RealName("visualDestructionNeeded")]
        public bool VisualDestructionNeeded { get; set; }
        
        [RealName("exploded")]
        public bool Exploded { get; set; }
        
        [RealName("sirenOn")]
        public bool SirenOn { get; set; }
        
        [RealName("sirenSoundOn")]
        public bool SirenSoundOn { get; set; }
        
        [RealName("sirenLightsOn")]
        public bool SirenLightsOn { get; set; }
        
        [RealName("anyDoorOpen")]
        public bool AnyDoorOpen { get; set; }
        
        [RealName("previousInteractionState")]
        public TemporaryDoorState[] PreviousInteractionState { get; set; }
        
        [RealName("thrusterState")]
        public bool ThrusterState { get; set; }
        
        [RealName("uiQuestModified")]
        public bool UiQuestModified { get; set; }
        
        [RealName("uiState")]
        public bool UiState { get; set; }
        
        [RealName("vehicleSkillChecks")]
        public Handle<EngDemoContainer> VehicleSkillChecks { get; set; }
        
        [RealName("ready")]
        public bool Ready { get; set; }
        
        [RealName("isPlayerPerformingBodyDisposal")]
        public bool IsPlayerPerformingBodyDisposal { get; set; }
        
        [RealName("vehicleControllerPS")]
        public Handle<VehicleControllerPS> VehicleControllerPS { get; set; }
    }
}
