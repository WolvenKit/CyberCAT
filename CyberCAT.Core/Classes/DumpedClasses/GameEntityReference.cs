using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameEntityReference")]
    public class GameEntityReference : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("type")]
        public DumpedEnums.gameEntityReferenceType? Type { get; set; }

        [RealName("reference")]
        [RealType("NodeRef")]
        public string Reference { get; set; }

        [RealName("names")]
        [RealType("CName")]
        public string[] Names { get; set; }

        [RealName("slotName")]
        [RealType("CName")]
        public string SlotName { get; set; }

        [RealName("sceneActorContextName")]
        [RealType("CName")]
        public string SceneActorContextName { get; set; }

        [RealName("dynamicEntityUniqueName")]
        [RealType("CName")]
        public string DynamicEntityUniqueName { get; set; }
    }
}