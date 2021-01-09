using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameCommunityID")]
    public class GameCommunityID : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("entityId")]
        public EntEntityID EntityId { get; set; }
    }
}
