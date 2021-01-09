using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SecurityAccessLevelEntry")]
    public class SecurityAccessLevelEntry : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("keycard")]
        [RealType("TweakDBID")]
        public TweakDbId Keycard { get; set; }
        
        [RealName("password")]
        [RealType("CName")]
        public string Password { get; set; }
    }
}
