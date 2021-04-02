using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameVisionModuleParams")]
    public class GameVisionModuleParams : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("visionTag")]
        public CName VisionTag { get; set; }
        
        [RealName("meshComponents")]
        public GameMeshDef[] MeshComponents { get; set; }
    }
}
