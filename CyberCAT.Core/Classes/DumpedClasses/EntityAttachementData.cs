using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("EntityAttachementData")]
    public class EntityAttachementData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("slotName")]
        public CName SlotName { get; set; }
        
        [RealName("slotComponentName")]
        public CName SlotComponentName { get; set; }
        
        [RealName("nodeRef")]
        public NodeRef NodeRef { get; set; }
        
        [RealName("attachementComponentName")]
        public CName AttachementComponentName { get; set; }
        
        [RealName("ownerID")]
        public EntEntityID OwnerID { get; set; }
    }
}
