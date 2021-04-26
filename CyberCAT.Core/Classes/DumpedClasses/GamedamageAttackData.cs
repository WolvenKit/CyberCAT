using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gamedamageAttackData")]
    public class GamedamageAttackData : IScriptable
    {
        [RealName("flags")]
        public SHitFlag[] Flags { get; set; }
        
        [RealName("statusEffects")]
        public SHitStatusEffect[] StatusEffects { get; set; }
        
        [RealName("hitType")]
        public DumpedEnums.gameuiHitType? HitType { get; set; }
        
        [RealName("vehicleImpactForce")]
        public float VehicleImpactForce { get; set; }
        
        [RealName("additionalCritChance")]
        public float AdditionalCritChance { get; set; }
        
        [RealName("attackType")]
        public DumpedEnums.gamedataAttackType? AttackType { get; set; }
        
        [RealName("instigator")]
        public GameObject Instigator { get; set; }
        
        [RealName("source")]
        public GameObject Source { get; set; }
        
        [RealName("weapon")]
        public GameweaponObject Weapon { get; set; }
        
        [RealName("attackDefinition")]
        public Handle<GameIAttack> AttackDefinition { get; set; }
        
        [RealName("attackPosition")]
        public Vector4 AttackPosition { get; set; }
        
        [RealName("weaponCharge")]
        public float WeaponCharge { get; set; }
        
        [RealName("numRicochetBounces")]
        public int NumRicochetBounces { get; set; }
    }
}
