using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameMeshDef")]
    public class GameMeshDef : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("componentName")]
        public CName ComponentName { get; set; }
    }
}
