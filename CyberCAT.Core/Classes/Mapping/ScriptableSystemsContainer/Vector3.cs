using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("Vector3")]
    public class Vector3 : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("X")]
        [RealType("Float")]
        public float X { get; set; }
        
        [RealName("Y")]
        [RealType("Float")]
        public float Y { get; set; }
        
        [RealName("Z")]
        [RealType("Float")]
        public float Z { get; set; }
    }
}
