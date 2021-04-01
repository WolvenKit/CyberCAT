using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameweaponObject")]
    public class GameweaponObject : GameItemObject
    {
        [RealName("hasOverheat")]
        public bool HasOverheat { get; set; }
        
        [RealName("overheatEffectBlackboard")]
        public Handle<WorldEffectBlackboard> OverheatEffectBlackboard { get; set; }
        
        [RealName("overheatListener")]
        public Handle<OverheatStatListener> OverheatListener { get; set; }
        
        [RealName("overheatDelaySent")]
        public bool OverheatDelaySent { get; set; }
        
        [RealName("chargeEffectBlackboard")]
        public Handle<WorldEffectBlackboard> ChargeEffectBlackboard { get; set; }
        
        [RealName("chargeStatListener")]
        public Handle<WeaponChargeStatListener> ChargeStatListener { get; set; }
        
        [RealName("meleeHitEffectBlackboard")]
        public Handle<WorldEffectBlackboard> MeleeHitEffectBlackboard { get; set; }
        
        [RealName("meleeHitEffectValue")]
        public float MeleeHitEffectValue { get; set; }
        
        [RealName("damageTypeListener")]
        public Handle<DamageStatListener> DamageTypeListener { get; set; }
        
        [RealName("trailName")]
        public string TrailName { get; set; }
        
        [RealName("maxChargeThreshold")]
        public float MaxChargeThreshold { get; set; }
        
        [RealName("lowAmmoEffectActive")]
        public bool LowAmmoEffectActive { get; set; }
        
        [RealName("AIBlackboard")]
        public Handle<GameIBlackboard> AIBlackboard { get; set; }
        
        [RealName("effect")]
        public GameEffectSet Effect { get; set; }
    }
}
