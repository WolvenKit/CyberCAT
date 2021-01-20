using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("senseStimuliData")]
    public class SenseStimuliData : IScriptable
    {
        [RealName("interval")]
        [RealType("Float")]
        public float Interval { get; set; }
        
        [RealName("isReactionStim")]
        [RealType("Bool")]
        public bool IsReactionStim { get; set; }
        
        [RealName("isSecurityAreaExclusive")]
        [RealType("Bool")]
        public bool IsSecurityAreaExclusive { get; set; }
        
        [RealName("fearValue")]
        [RealType("Float")]
        public float FearValue { get; set; }
        
        [RealName("shockValue")]
        [RealType("Float")]
        public float ShockValue { get; set; }
        
        [RealName("sadValue")]
        [RealType("Float")]
        public float SadValue { get; set; }
        
        [RealName("joyValue")]
        [RealType("Float")]
        public float JoyValue { get; set; }
        
        [RealName("surpriseValue")]
        [RealType("Float")]
        public float SurpriseValue { get; set; }
        
        [RealName("disgustValue")]
        [RealType("Float")]
        public float DisgustValue { get; set; }
        
        [RealName("aggressiveValue")]
        [RealType("Float")]
        public float AggressiveValue { get; set; }
        
        [RealName("funnyValue")]
        [RealType("Float")]
        public float FunnyValue { get; set; }
        
        [RealName("curiosityValue")]
        [RealType("Float")]
        public float CuriosityValue { get; set; }
        
        [RealName("stimPriority")]
        [RealType("Int32")]
        public int StimPriority { get; set; }
    }
}
