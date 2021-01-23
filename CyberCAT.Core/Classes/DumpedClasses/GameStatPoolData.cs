using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameStatPoolData")]
    public class GameStatPoolData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("ownerID")]
        public GameStatsObjectID OwnerID { get; set; }
        
        [RealName("recordID")]
        public TweakDbId RecordID { get; set; }
        
        [RealName("type")]
        public DumpedEnums.gamedataStatPoolType? Type { get; set; }
        
        [RealName("modifiers")]
        [RealType("gameStatPoolModifier", IsFixedArray = true)]
        public GameStatPoolModifier[] Modifiers { get; set; }
        
        [RealName("alternativeModifierRecords")]
        [RealType("TweakDBID", IsFixedArray = true)]
        public TweakDbId[] AlternativeModifierRecords { get; set; }
        
        [RealName("stat")]
        public DumpedEnums.gamedataStatType? Stat { get; set; }
        
        [RealName("maxValue")]
        public float MaxValue { get; set; }
        
        [RealName("customLimitValue")]
        public float CustomLimitValue { get; set; }
        
        [RealName("changeMode")]
        public DumpedEnums.gameStatPoolDataValueChangeMode? ChangeMode { get; set; }
        
        [RealName("bonus")]
        public float Bonus { get; set; }
        
        [RealName("bonusType")]
        public DumpedEnums.gameStatPoolDataBonusType? BonusType { get; set; }
        
        [RealName("currentValue")]
        public float CurrentValue { get; set; }
        
        [RealName("modificationDelay")]
        public float ModificationDelay { get; set; }
        
        [RealName("modificationStatus")]
        public DumpedEnums.gameStatPoolDataStatPoolModificationStatus? ModificationStatus { get; set; }
    }
}
