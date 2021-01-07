using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("vehicleDestructionPSData")]
    public class VehicleDestructionPSData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("gridValues")]
        [RealType("Float", IsArray = true)]
        public float[] GridValues { get; set; }
        
        [RealName("brokenGlass")]
        [RealType("Uint32")]
        public uint BrokenGlass { get; set; }
        
        [RealName("brokenLights")]
        [RealType("Uint32")]
        public uint BrokenLights { get; set; }
        
        [RealName("flatTire")]
        [RealType("Uint8")]
        public byte FlatTire { get; set; }
        
        [RealName("windshieldShattered")]
        [RealType("Bool")]
        public bool WindshieldShattered { get; set; }
        
        [RealName("windshieldPoints")]
        public Vector3[] WindshieldPoints { get; set; }
        
        [RealName("detachedParts")]
        [RealType("CName")]
        public string[] DetachedParts { get; set; }
    }
}
