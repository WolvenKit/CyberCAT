using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SecurityTurretControllerPS")]
    public class SecurityTurretControllerPS : SensorDeviceControllerPS
    {
        [RealName("pendingSecuritySystemDisableRequest")]
        public bool PendingSecuritySystemDisableRequest { get; set; }
        
        [RealName("turretSkillChecks")]
        public Handle<EngDemoContainer> TurretSkillChecks { get; set; }
        
        [RealName("ignoreSkillcheckGeneration")]
        public bool IgnoreSkillcheckGeneration { get; set; }
        
        [RealName("laserGameEffectRef")]
        public GameEffectRef LaserGameEffectRef { get; set; }
        
        [RealName("weaponItemRecordString")]
        public string WeaponItemRecordString { get; set; }
        
        [RealName("vfxNameOnShoot")]
        public CName VfxNameOnShoot { get; set; }
    }
}
