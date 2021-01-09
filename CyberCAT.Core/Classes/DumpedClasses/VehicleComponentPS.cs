using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("VehicleComponentPS")]
    public class VehicleComponentPS : ScriptableDeviceComponentPS
    {
        [RealName("defaultStateSet")]
        [RealType("Bool")]
        public bool DefaultStateSet { get; set; }
        
        [RealName("stateModifiedByQuest")]
        [RealType("Bool")]
        public bool StateModifiedByQuest { get; set; }
        
        [RealName("playerVehicle")]
        [RealType("Bool")]
        public bool PlayerVehicle { get; set; }
        
        [RealName("npcOccupiedSlots")]
        [RealType("CName")]
        public string[] NpcOccupiedSlots { get; set; }
        
        [RealName("isDestroyed")]
        [RealType("Bool")]
        public bool IsDestroyed { get; set; }
        
        [RealName("isStolen")]
        [RealType("Bool")]
        public bool IsStolen { get; set; }
        
        [RealName("crystalDomeQuestModified")]
        [RealType("Bool")]
        public bool CrystalDomeQuestModified { get; set; }
        
        [RealName("crystalDomeQuestState")]
        [RealType("Bool")]
        public bool CrystalDomeQuestState { get; set; }
        
        [RealName("crystalDomeState")]
        [RealType("Bool")]
        public bool CrystalDomeState { get; set; }
        
        [RealName("visualDestructionSet")]
        [RealType("Bool")]
        public bool VisualDestructionSet { get; set; }
        
        [RealName("visualDestructionNeeded")]
        [RealType("Bool")]
        public bool VisualDestructionNeeded { get; set; }
        
        [RealName("exploded")]
        [RealType("Bool")]
        public bool Exploded { get; set; }
        
        [RealName("sirenOn")]
        [RealType("Bool")]
        public bool SirenOn { get; set; }
        
        [RealName("sirenSoundOn")]
        [RealType("Bool")]
        public bool SirenSoundOn { get; set; }
        
        [RealName("sirenLightsOn")]
        [RealType("Bool")]
        public bool SirenLightsOn { get; set; }
        
        [RealName("anyDoorOpen")]
        [RealType("Bool")]
        public bool AnyDoorOpen { get; set; }
        
        [RealName("previousInteractionState")]
        public TemporaryDoorState[] PreviousInteractionState { get; set; }
        
        [RealName("thrusterState")]
        [RealType("Bool")]
        public bool ThrusterState { get; set; }
        
        [RealName("uiQuestModified")]
        [RealType("Bool")]
        public bool UiQuestModified { get; set; }
        
        [RealName("uiState")]
        [RealType("Bool")]
        public bool UiState { get; set; }
        
        [RealName("vehicleSkillChecks")]
        public Handle<EngDemoContainer> VehicleSkillChecks { get; set; }
        
        [RealName("ready")]
        [RealType("Bool")]
        public bool Ready { get; set; }
        
        [RealName("isPlayerPerformingBodyDisposal")]
        [RealType("Bool")]
        public bool IsPlayerPerformingBodyDisposal { get; set; }
        
        [RealName("vehicleControllerPS")]
        public Handle<VehicleControllerPS> VehicleControllerPS { get; set; }
    }
}
