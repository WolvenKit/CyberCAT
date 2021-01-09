using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameSquadMemberComponentPS")]
    public class GameSquadMemberComponentPS : GameComponentPS
    {
        [RealName("entries")]
        public GameSquadMemberDataEntry[] Entries { get; set; }
    }
}
