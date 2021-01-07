using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameStatViewData")]
    public class GameStatViewData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("type")]
        public DumpedEnums.gamedataStatType? Type { get; set; }
        
        [RealName("statName")]
        [RealType("String")]
        public string StatName { get; set; }
        
        [RealName("value")]
        [RealType("Int32")]
        public int Value { get; set; }
        
        [RealName("diffValue")]
        [RealType("Int32")]
        public int DiffValue { get; set; }
        
        [RealName("isMaxValue")]
        [RealType("Bool")]
        public bool IsMaxValue { get; set; }
        
        [RealName("valueF")]
        [RealType("Float")]
        public float ValueF { get; set; }
        
        [RealName("diffValueF")]
        [RealType("Float")]
        public float DiffValueF { get; set; }
        
        [RealName("statMinValueF")]
        [RealType("Float")]
        public float StatMinValueF { get; set; }
        
        [RealName("statMaxValueF")]
        [RealType("Float")]
        public float StatMaxValueF { get; set; }
        
        [RealName("canBeCompared")]
        [RealType("Bool")]
        public bool CanBeCompared { get; set; }
        
        [RealName("isCompared")]
        [RealType("Bool")]
        public bool IsCompared { get; set; }
        
        [RealName("statMinValue")]
        [RealType("Int32")]
        public int StatMinValue { get; set; }
        
        [RealName("statMaxValue")]
        [RealType("Int32")]
        public int StatMaxValue { get; set; }
    }
}
