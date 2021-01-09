using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("TerminalSetup")]
    public class TerminalSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("minClearance")]
        [RealType("Int32")]
        public int MinClearance { get; set; }
        
        [RealName("maxClearance")]
        [RealType("Int32")]
        public int MaxClearance { get; set; }
        
        [RealName("ignoreSlaveAuthorizationModule")]
        [RealType("Bool")]
        public bool IgnoreSlaveAuthorizationModule { get; set; }
        
        [RealName("shouldForceVirtualSystem")]
        [RealType("Bool")]
        public bool ShouldForceVirtualSystem { get; set; }
    }
}
