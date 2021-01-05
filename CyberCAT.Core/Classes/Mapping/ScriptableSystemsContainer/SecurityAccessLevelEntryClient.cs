
namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("SecurityAccessLevelEntryClient")]
    public class SecurityAccessLevelEntryClient : SecurityAccessLevelEntry
    {
        [RealName("level")]
        public DumpedEnums.ESecurityAccessLevel? Level { get; set; }
    }
}
