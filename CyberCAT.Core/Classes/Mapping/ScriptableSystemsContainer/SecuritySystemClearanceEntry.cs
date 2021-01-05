using CyberCAT.Core.Classes.Mapping.Global;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("SecuritySystemClearanceEntry")]
    public class SecuritySystemClearanceEntry : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("user")]
        public EntEntityID User { get; set; }
        
        [RealName("level")]
        public DumpedEnums.ESecurityAccessLevel? Level { get; set; }
    }
}
