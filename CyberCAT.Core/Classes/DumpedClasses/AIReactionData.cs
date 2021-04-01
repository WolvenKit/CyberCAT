using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AIReactionData")]
    public class AIReactionData : IScriptable
    {
        [RealName("reactionPriority")]
        public int ReactionPriority { get; set; }
        
        [RealName("reactionBehaviorName")]
        public DumpedEnums.gamedataOutput? ReactionBehaviorName { get; set; }
        
        [RealName("reactionBehaviorAIPriority")]
        public float ReactionBehaviorAIPriority { get; set; }
        
        [RealName("reactionCooldown")]
        public float ReactionCooldown { get; set; }
        
        [RealName("stimTarget")]
        public GameObject StimTarget { get; set; }
        
        [RealName("stimSource")]
        public Vector4 StimSource { get; set; }
        
        [RealName("stimType")]
        public DumpedEnums.gamedataStimType? StimType { get; set; }
        
        [RealName("stimPriority")]
        public DumpedEnums.gamedataStimPriority? StimPriority { get; set; }
        
        [RealName("stimData")]
        public Handle<SenseStimuliData> StimData { get; set; }
        
        [RealName("stimInvestigateData")]
        public StimInvestigateData StimInvestigateData { get; set; }
        
        [RealName("stimEventData")]
        public StimEventData StimEventData { get; set; }
        
        [RealName("initAnimInWorkspot")]
        public bool InitAnimInWorkspot { get; set; }
        
        [RealName("validTillTimeStamp")]
        public float ValidTillTimeStamp { get; set; }
        
        [RealName("recentReactionTimeStamp")]
        public float RecentReactionTimeStamp { get; set; }
        
        [RealName("escalateProvoke")]
        public bool EscalateProvoke { get; set; }
    }
}
