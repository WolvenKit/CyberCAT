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
        public bool ExplosiveWithQhacks { get; set; }
        
        [RealName("HealthDecay")]
        public float HealthDecay { get; set; }
        
        [RealName("timeToMeshSwap")]
        public float TimeToMeshSwap { get; set; }
        
        [RealName("shouldDistractionHitVFXIgnoreHitPosition")]
        public bool ShouldDistractionHitVFXIgnoreHitPosition { get; set; }
        
        [RealName("canBeDisabledWithQhacks")]
        public bool CanBeDisabledWithQhacks { get; set; }
        
        [RealName("disarmed")]
        public bool Disarmed { get; set; }
        
        [RealName("exploded")]
        public bool Exploded { get; set; }
        
        [RealName("provideExplodeAction")]
        public bool ProvideExplodeAction { get; set; }
        
        [RealName("doExplosiveEngineerLogic")]
        public bool DoExplosiveEngineerLogic { get; set; }
    }
}
