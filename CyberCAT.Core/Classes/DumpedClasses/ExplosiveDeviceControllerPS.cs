using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ExplosiveDeviceControllerPS")]
    public class ExplosiveDeviceControllerPS : BasicDistractionDeviceControllerPS
    {
        [RealName("explosiveSkillChecks")]
        public Handle<EngDemoContainer> ExplosiveSkillChecks { get; set; }
        
        [RealName("explosionDefinition")]
        public ExplosiveDeviceResourceDefinition[] ExplosionDefinition { get; set; }
        
        [RealName("explosiveWithQhacks")]
        [RealType("Bool")]
        public bool ExplosiveWithQhacks { get; set; }
        
        [RealName("HealthDecay")]
        [RealType("Float")]
        public float HealthDecay { get; set; }
        
        [RealName("timeToMeshSwap")]
        [RealType("Float")]
        public float TimeToMeshSwap { get; set; }
        
        [RealName("shouldDistractionHitVFXIgnoreHitPosition")]
        [RealType("Bool")]
        public bool ShouldDistractionHitVFXIgnoreHitPosition { get; set; }
        
        [RealName("canBeDisabledWithQhacks")]
        [RealType("Bool")]
        public bool CanBeDisabledWithQhacks { get; set; }
        
        [RealName("disarmed")]
        [RealType("Bool")]
        public bool Disarmed { get; set; }
        
        [RealName("exploded")]
        [RealType("Bool")]
        public bool Exploded { get; set; }
        
        [RealName("provideExplodeAction")]
        [RealType("Bool")]
        public bool ProvideExplodeAction { get; set; }
        
        [RealName("doExplosiveEngineerLogic")]
        [RealType("Bool")]
        public bool DoExplosiveEngineerLogic { get; set; }
    }
}
