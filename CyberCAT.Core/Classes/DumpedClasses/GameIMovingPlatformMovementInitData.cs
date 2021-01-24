using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameIMovingPlatformMovementInitData")]
    public class GameIMovingPlatformMovementInitData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("initType")]
        public DumpedEnums.gameMovingPlatformMovementInitializationType? InitType { get; set; }
        
        [RealName("initValue")]
        public float InitValue { get; set; }
        
        [RealName("startNode")]
        public NodeRef StartNode { get; set; }
        
        [RealName("endNode")]
        public NodeRef EndNode { get; set; }
    }
}
