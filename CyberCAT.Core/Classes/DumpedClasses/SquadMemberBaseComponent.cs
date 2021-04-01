using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SquadMemberBaseComponent")]
    public class SquadMemberBaseComponent : GameSquadMemberComponent
    {
        [RealName("baseSquadRecord")]
        public GamedataAISquadParams_Record BaseSquadRecord { get; set; }
    }
}
