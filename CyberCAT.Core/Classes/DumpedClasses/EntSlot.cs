using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("entSlot")]
    public class EntSlot : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("slotName")]
        public CName SlotName { get; set; }
        
        [RealName("boneName")]
        public CName BoneName { get; set; }
        
        [RealName("relativePosition")]
        public Vector3 RelativePosition { get; set; }
        
        [RealName("relativeRotation")]
        public Quaternion RelativeRotation { get; set; }
    }
}
