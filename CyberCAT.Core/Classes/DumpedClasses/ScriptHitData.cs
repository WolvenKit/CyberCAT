using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ScriptHitData")]
    public class ScriptHitData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("animVariation")]
        public int AnimVariation { get; set; }
        
        [RealName("attackDirection")]
        public int AttackDirection { get; set; }
        
        [RealName("hitBodyPart")]
        public int HitBodyPart { get; set; }
    }
}
