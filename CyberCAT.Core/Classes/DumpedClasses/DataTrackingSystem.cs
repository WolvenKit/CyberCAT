using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DataTrackingSystem")]
    public class DataTrackingSystem : GameScriptableSystem
    {
        [RealName("achievementsMask")]
        public bool[] AchievementsMask { get; set; }
        
        [RealName("rangedAttacksMade")]
        public int RangedAttacksMade { get; set; }
        
        [RealName("meleeAttacksMade")]
        public int MeleeAttacksMade { get; set; }
        
        [RealName("meleeKills")]
        public int MeleeKills { get; set; }
        
        [RealName("rangedKills")]
        public int RangedKills { get; set; }
        
        [RealName("quickhacksMade")]
        public int QuickhacksMade { get; set; }
        
        [RealName("distractionsMade")]
        public int DistractionsMade { get; set; }
        
        [RealName("legendaryItemsCrafted")]
        public int LegendaryItemsCrafted { get; set; }
        
        [RealName("npcMeleeLightAttackReceived")]
        public int NpcMeleeLightAttackReceived { get; set; }
        
        [RealName("npcMeleeStrongAttackReceived")]
        public int NpcMeleeStrongAttackReceived { get; set; }
        
        [RealName("npcMeleeBlockAttackReceived")]
        public int NpcMeleeBlockAttackReceived { get; set; }
        
        [RealName("npcMeleeBlockedAttacks")]
        public int NpcMeleeBlockedAttacks { get; set; }
        
        [RealName("npcMeleeDeflectedAttacks")]
        public int NpcMeleeDeflectedAttacks { get; set; }
        
        [RealName("downedEnemies")]
        public int DownedEnemies { get; set; }
        
        [RealName("killedEnemies")]
        public int KilledEnemies { get; set; }
        
        [RealName("defeatedEnemies")]
        public int DefeatedEnemies { get; set; }
        
        [RealName("incapacitatedEnemies")]
        public int IncapacitatedEnemies { get; set; }
        
        [RealName("finishedEnemies")]
        public int FinishedEnemies { get; set; }
        
        [RealName("downedWithRanged")]
        public int DownedWithRanged { get; set; }
        
        [RealName("downedWithMelee")]
        public int DownedWithMelee { get; set; }
        
        [RealName("downedInTimeDilatation")]
        public int DownedInTimeDilatation { get; set; }
        
        [RealName("rangedProgress")]
        public int RangedProgress { get; set; }
        
        [RealName("meleeProgress")]
        public int MeleeProgress { get; set; }
        
        [RealName("dilationProgress")]
        public int DilationProgress { get; set; }
        
        [RealName("failedShardDrops")]
        public float FailedShardDrops { get; set; }
        
        [RealName("bluelinesUseCount")]
        public int BluelinesUseCount { get; set; }
        
        [RealName("twoHeadssourceID")]
        public EntEntityID TwoHeadssourceID { get; set; }
        
        [RealName("twoHeadsValidTimestamp")]
        public float TwoHeadsValidTimestamp { get; set; }
        
        [RealName("lastKillTimestamp")]
        public float LastKillTimestamp { get; set; }
        
        [RealName("enemiesKilledInTimeInterval")]
        public GameObject[] EnemiesKilledInTimeInterval { get; set; }
        
        [RealName("timeInterval")]
        public float TimeInterval { get; set; }
        
        [RealName("numerOfKillsRequired")]
        public int NumerOfKillsRequired { get; set; }
        
        [RealName("gunKataInProgress")]
        public bool GunKataInProgress { get; set; }
        
        [RealName("gunKataKilledEnemies")]
        public int GunKataKilledEnemies { get; set; }
        
        [RealName("gunKataValidTimestamp")]
        public float GunKataValidTimestamp { get; set; }
        
        [RealName("hardKneesInProgress")]
        public bool HardKneesInProgress { get; set; }
        
        [RealName("hardKneesKilledEnemies")]
        public int HardKneesKilledEnemies { get; set; }
        
        [RealName("harKneesValidTimestamp")]
        public float HarKneesValidTimestamp { get; set; }
        
        [RealName("resetKilledReqDelayID")]
        public GameDelayID ResetKilledReqDelayID { get; set; }
        
        [RealName("resetFinishedReqDelayID")]
        public GameDelayID ResetFinishedReqDelayID { get; set; }
        
        [RealName("resetDefeatedReqDelayID")]
        public GameDelayID ResetDefeatedReqDelayID { get; set; }
        
        [RealName("resetIncapacitatedReqDelayID")]
        public GameDelayID ResetIncapacitatedReqDelayID { get; set; }
        
        [RealName("resetDownedReqDelayID")]
        public GameDelayID ResetDownedReqDelayID { get; set; }
        
        [RealName("resetMeleeAttackReqDelayID")]
        public GameDelayID ResetMeleeAttackReqDelayID { get; set; }
        
        [RealName("resetRangedAttackReqDelayID")]
        public GameDelayID ResetRangedAttackReqDelayID { get; set; }
        
        [RealName("resetAttackReqDelayID")]
        public GameDelayID ResetAttackReqDelayID { get; set; }
        
        [RealName("resetNpcMeleeLightAttackReqDelayID")]
        public GameDelayID ResetNpcMeleeLightAttackReqDelayID { get; set; }
        
        [RealName("resetNpcMeleeStrongAttackReqDelayID")]
        public GameDelayID ResetNpcMeleeStrongAttackReqDelayID { get; set; }
        
        [RealName("resetNpcMeleeFinalAttackReqDelayID")]
        public GameDelayID ResetNpcMeleeFinalAttackReqDelayID { get; set; }
        
        [RealName("resetNpcMeleeBlockAttackReqDelayID")]
        public GameDelayID ResetNpcMeleeBlockAttackReqDelayID { get; set; }
        
        [RealName("resetNpcBlockedReqDelayID")]
        public GameDelayID ResetNpcBlockedReqDelayID { get; set; }
        
        [RealName("resetNpcDeflectedReqDelayID")]
        public GameDelayID ResetNpcDeflectedReqDelayID { get; set; }
        
        [RealName("resetNpcGuardbreakReqDelayID")]
        public GameDelayID ResetNpcGuardbreakReqDelayID { get; set; }
    }
}
