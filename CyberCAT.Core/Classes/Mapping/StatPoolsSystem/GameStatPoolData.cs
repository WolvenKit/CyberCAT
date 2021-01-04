using CyberCAT.Core.Classes.Mapping.Global;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.StatPoolsSystem
{
    [RealName("gameStatPoolData")]
    public class GameStatPoolData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("ownerID")]
        public GameStatsObjectID OwnerID { get; set; }
        
        [RealName("recordID")]
        [RealType("TweakDBID")]
        public ulong RecordID { get; set; }
        
        [RealName("type")]
        public DumpedEnums.gamedataStatPoolType Type { get; set; }
        
        [RealName("modifiers")]
        [RealType("gameStatPoolModifier", IsArray = true)]
        public GameStatPoolModifier[] Modifiers { get; set; }

        [RealName("alternativeModifierRecords")]
        [RealType("TweakDBID", IsArray = true)]
        public ulong[] AlternativeModifierRecords { get; set; }

        [RealName("stat")]
        public DumpedEnums.gamedataStatType Stat { get; set; }
        
        [RealName("maxValue")]
        [RealType("Float")]
        public float MaxValue { get; set; }

        [RealName("customLimitValue")]
        [RealType("Float")]
        public float CustomLimitValue { get; set; }

        [RealName("changeMode")]
        public DumpedEnums.gameStatPoolDataValueChangeMode ChangeMode { get; set; }

        [RealName("bonus")]
        [RealType("Float")]
        public float Bonus { get; set; }

        [ParserIgnore]
        [RealName("bonusType")]
        public DumpedEnums.gameStatPoolDataBonusType BonusType { get; set; }

        [RealName("currentValue")]
        [RealType("Float")]
        public float CurrentValue { get; set; }
        
        [RealName("modificationDelay")]
        [RealType("Float")]
        public float ModificationDelay { get; set; }

        [RealName("modificationStatus")]
        public DumpedEnums.gameStatPoolDataStatPoolModificationStatus ModificationStatus { get; set; }
    }
}
