using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SecurityTurretControllerPS")]
    public class SecurityTurretControllerPS : SensorDeviceControllerPS
    {
        [RealName("pendingSecuritySystemDisableRequest")]
        [RealType("Bool")]
        public bool PendingSecuritySystemDisableRequest { get; set; }
        
        [RealName("turretSkillChecks")]
        public Handle<EngDemoContainer> TurretSkillChecks { get; set; }
        
        [RealName("ignoreSkillcheckGeneration")]
        [RealType("Bool")]
        public bool IgnoreSkillcheckGeneration { get; set; }
        
        [RealName("laserGameEffectRef")]
        public GameEffectRef LaserGameEffectRef { get; set; }
        
        [RealName("weaponItemRecordString")]
        [RealType("String")]
        public string WeaponItemRecordString { get; set; }
        
        [RealName("vfxNameOnShoot")]
        [RealType("CName")]
        public string VfxNameOnShoot { get; set; }
    }
}
