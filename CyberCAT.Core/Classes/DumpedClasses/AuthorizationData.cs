using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AuthorizationData")]
    public class AuthorizationData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("isAuthorizationModuleOn")]
        public bool IsAuthorizationModuleOn { get; set; }
        
        [RealName("alwaysExposeActions")]
        public bool AlwaysExposeActions { get; set; }
        
        [RealName("authorizationDataEntry")]
        public SecurityAccessLevelEntryClient AuthorizationDataEntry { get; set; }

        public AuthorizationData()
        {
            IsAuthorizationModuleOn = true;
        }
    }
}
