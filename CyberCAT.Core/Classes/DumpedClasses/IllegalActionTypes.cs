using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("IllegalActionTypes")]
    public class IllegalActionTypes : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("regularActions")]
        public bool RegularActions { get; set; }
        
        [RealName("quickHacks")]
        public bool QuickHacks { get; set; }
        
        [RealName("skillChecks")]
        public bool SkillChecks { get; set; }

        public IllegalActionTypes()
        {
            SkillChecks = true;
        }
    }
}
