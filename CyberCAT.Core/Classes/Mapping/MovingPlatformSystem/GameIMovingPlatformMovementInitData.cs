using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.MovingPlatformSystem
{
    [RealName("gameIMovingPlatformMovementInitData")]
    public class GameIMovingPlatformMovementInitData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("initType")]
        public DumpedEnums.gameMovingPlatformMovementInitializationType? InitType { get; set; }

        [RealName("initValue")]
        [RealType("Float")]
        public float InitValue { get; set; }

        [RealName("startNode")]
        [RealType("NodeRef")]
        public string StartNode { get; set; }

        [RealName("endNode")]
        [RealType("NodeRef")]
        public string EndNode { get; set; }
    }
}