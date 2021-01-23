using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("senseStimuliData")]
    public class SenseStimuliData : IScriptable
    {
        [RealName("interval")]
        public float Interval { get; set; }
        
        [RealName("isReactionStim")]
        public bool IsReactionStim { get; set; }
        
        [RealName("isSecurityAreaExclusive")]
        public bool IsSecurityAreaExclusive { get; set; }
        
        [RealName("fearValue")]
        public float FearValue { get; set; }
        
        [RealName("shockValue")]
        public float ShockValue { get; set; }
        
        [RealName("sadValue")]
        public float SadValue { get; set; }
        
        [RealName("joyValue")]
        public float JoyValue { get; set; }
        
        [RealName("surpriseValue")]
        public float SurpriseValue { get; set; }
        
        [RealName("disgustValue")]
        public float DisgustValue { get; set; }
        
        [RealName("aggressiveValue")]
        public float AggressiveValue { get; set; }
        
        [RealName("funnyValue")]
        public float FunnyValue { get; set; }
        
        [RealName("curiosityValue")]
        public float CuriosityValue { get; set; }
        
        [RealName("stimPriority")]
        public int StimPriority { get; set; }
    }
}
