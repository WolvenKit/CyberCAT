using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameSquadMemberDataEntry")]
    public class GameSquadMemberDataEntry : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("squadName")]
        public CName SquadName { get; set; }
        
        [RealName("squadType")]
        public DumpedEnums.AISquadType? SquadType { get; set; }
    }
}
