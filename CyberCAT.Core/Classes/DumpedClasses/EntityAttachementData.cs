using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("EntityAttachementData")]
    public class EntityAttachementData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("slotName")]
        [RealType("CName")]
        public string SlotName { get; set; }
        
        [RealName("slotComponentName")]
        [RealType("CName")]
        public string SlotComponentName { get; set; }
        
        [RealName("nodeRef")]
        [RealType("NodeRef")]
        public string NodeRef { get; set; }
        
        [RealName("attachementComponentName")]
        [RealType("CName")]
        public string AttachementComponentName { get; set; }
        
        [RealName("ownerID")]
        public EntEntityID OwnerID { get; set; }
    }
}
