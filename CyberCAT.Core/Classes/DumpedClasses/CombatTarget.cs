using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("CombatTarget")]
    public class CombatTarget : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("puppet")]
        public ScriptedPuppet Puppet { get; set; }
        
        [RealName("hasTime")]
        public bool HasTime { get; set; }
        
        [RealName("highlightTime")]
        public float HighlightTime { get; set; }
    }
}
