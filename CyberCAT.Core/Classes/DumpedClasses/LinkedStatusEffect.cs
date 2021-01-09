using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("LinkedStatusEffect")]
    public class LinkedStatusEffect : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("netrunnerIDs")]
        public EntEntityID[] NetrunnerIDs { get; set; }
        
        [RealName("targetID")]
        public EntEntityID TargetID { get; set; }
        
        [RealName("statusEffectList")]
        [RealType("TweakDBID")]
        public TweakDbId[] StatusEffectList { get; set; }
    }
}
