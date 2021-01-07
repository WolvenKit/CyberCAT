using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SecurityAccessLevelEntryClient")]
    public class SecurityAccessLevelEntryClient : SecurityAccessLevelEntry
    {
        [RealName("level")]
        public DumpedEnums.ESecurityAccessLevel? Level { get; set; }
    }
}
