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
        public NodeRef Reference { get; set; }

        [RealName("names")]
        public CName[] Names { get; set; }

        [RealName("slotName")]
        public CName SlotName { get; set; }

        [RealName("sceneActorContextName")]
        public CName SceneActorContextName { get; set; }

        [RealName("dynamicEntityUniqueName")]
        public CName DynamicEntityUniqueName { get; set; }
    }
}