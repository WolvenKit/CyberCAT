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
        public string StatName { get; set; }
        
        [RealName("value")]
        public int Value { get; set; }
        
        [RealName("diffValue")]
        public int DiffValue { get; set; }
        
        [RealName("isMaxValue")]
        public bool IsMaxValue { get; set; }
        
        [RealName("valueF")]
        public float ValueF { get; set; }
        
        [RealName("diffValueF")]
        public float DiffValueF { get; set; }
        
        [RealName("statMinValueF")]
        public float StatMinValueF { get; set; }
        
        [RealName("statMaxValueF")]
        public float StatMaxValueF { get; set; }
        
        [RealName("canBeCompared")]
        public bool CanBeCompared { get; set; }
        
        [RealName("isCompared")]
        public bool IsCompared { get; set; }
        
        [RealName("statMinValue")]
        public int StatMinValue { get; set; }
        
        [RealName("statMaxValue")]
        public int StatMaxValue { get; set; }
    }
}
