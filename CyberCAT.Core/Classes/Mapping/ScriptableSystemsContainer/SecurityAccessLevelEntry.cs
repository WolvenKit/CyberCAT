using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
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
