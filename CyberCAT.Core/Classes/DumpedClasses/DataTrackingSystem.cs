using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DataTrackingSystem")]
    public class DataTrackingSystem : GameScriptableSystem
    {
        [RealName("achievementsMask")]
        [RealType("Bool")]
        public bool[] AchievementsMask { get; set; }
        
        [RealName("rangedAttacksMade")]
        [RealType("Int32")]
        public int RangedAttacksMade { get; set; }
        
        [RealName("meleeAttacksMade")]
        [RealType("Int32")]
        public int MeleeAttacksMade { get; set; }
        
        [RealName("meleeKills")]
        [RealType("Int32")]
        public int MeleeKills { get; set; }
        
        [RealName("rangedKills")]
        [RealType("Int32")]
        public int RangedKills { get; set; }
        
        [RealName("quickhacksMade")]
        [RealType("Int32")]
        public int QuickhacksMade { get; set; }
        
        [RealName("distractionsMade")]
        [RealType("Int32")]
        public int DistractionsMade { get; set; }
        
        [RealName("legendaryItemsCrafted")]
        [RealType("Int32")]
        public int LegendaryItemsCrafted { get; set; }
        
        [RealName("npcMeleeLightAttackReceived")]
        [RealType("Int32")]
        public int NpcMeleeLightAttackReceived { get; set; }
        
        [RealName("npcMeleeStrongAttackReceived")]
        [RealType("Int32")]
        public int NpcMeleeStrongAttackReceived { get; set; }
        
        [RealName("npcMeleeBlockAttackReceived")]
        [RealType("Int32")]
        public int NpcMeleeBlockAttackReceived { get; set; }
        
        [RealName("npcMeleeBlockedAttacks")]
        [RealType("Int32")]
        public int NpcMeleeBlockedAttacks { get; set; }
        
        [RealName("npcMeleeDeflectedAttacks")]
        [RealType("Int32")]
        public int NpcMeleeDeflectedAttacks { get; set; }
        
        [RealName("downedEnemies")]
        [RealType("Int32")]
        public int DownedEnemies { get; set; }
        
        [RealName("killedEnemies")]
        [RealType("Int32")]
        public int KilledEnemies { get; set; }
        
        [RealName("defeatedEnemies")]
        [RealType("Int32")]
        public int DefeatedEnemies { get; set; }
        
        [RealName("incapacitatedEnemies")]
        [RealType("Int32")]
        public int IncapacitatedEnemies { get; set; }
        
        [RealName("finishedEnemies")]
        [RealType("Int32")]
        public int FinishedEnemies { get; set; }
        
        [RealName("downedWithRanged")]
        [RealType("Int32")]
        public int DownedWithRanged { get; set; }
        
        [RealName("downedWithMelee")]
        [RealType("Int32")]
        public int DownedWithMelee { get; set; }
        
        [RealName("downedInTimeDilatation")]
        [RealType("Int32")]
        public int DownedInTimeDilatation { get; set; }
        
        [RealName("rangedProgress")]
        [RealType("Int32")]
        public int RangedProgress { get; set; }
        
        [RealName("meleeProgress")]
        [RealType("Int32")]
        public int MeleeProgress { get; set; }
        
        [RealName("dilationProgress")]
        [RealType("Int32")]
        public int DilationProgress { get; set; }
        
        [RealName("failedShardDrops")]
        [RealType("Float")]
        public float FailedShardDrops { get; set; }
        
        [RealName("bluelinesUseCount")]
        [RealType("Int32")]
        public int BluelinesUseCount { get; set; }
        
        [RealName("twoHeadssourceID")]
        public EntEntityID TwoHeadssourceID { get; set; }
        
        [RealName("twoHeadsValidTimestamp")]
        [RealType("Float")]
        public float TwoHeadsValidTimestamp { get; set; }
        
        [RealName("lastKillTimestamp")]
        [RealType("Float")]
        public float LastKillTimestamp { get; set; }
        
        [RealName("timeInterval")]
        [RealType("Float")]
        public float TimeInterval { get; set; }
        
        [RealName("numerOfKillsRequired")]
        [RealType("Int32")]
        public int NumerOfKillsRequired { get; set; }
        
        [RealName("gunKataInProgress")]
        [RealType("Bool")]
        public bool GunKataInProgress { get; set; }
        
        [RealName("gunKataKilledEnemies")]
        [RealType("Int32")]
        public int GunKataKilledEnemies { get; set; }
        
        [RealName("gunKataValidTimestamp")]
        [RealType("Float")]
        public float GunKataValidTimestamp { get; set; }
        
        [RealName("hardKneesInProgress")]
        [RealType("Bool")]
        public bool HardKneesInProgress { get; set; }
        
        [RealName("hardKneesKilledEnemies")]
        [RealType("Int32")]
        public int HardKneesKilledEnemies { get; set; }
        
        [RealName("harKneesValidTimestamp")]
        [RealType("Float")]
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
