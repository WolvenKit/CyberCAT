using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("TerminalSetup")]
    public class TerminalSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("minClearance")]
        public int MinClearance { get; set; }
        
        [RealName("maxClearance")]
        public int MaxClearance { get; set; }
        
        [RealName("ignoreSlaveAuthorizationModule")]
        public bool IgnoreSlaveAuthorizationModule { get; set; }
        
        [RealName("shouldForceVirtualSystem")]
        public bool ShouldForceVirtualSystem { get; set; }
    }
}
