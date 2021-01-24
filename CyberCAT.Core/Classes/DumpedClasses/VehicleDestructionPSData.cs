using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("vehicleDestructionPSData")]
    public class VehicleDestructionPSData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("gridValues")]
        [RealType("Float", IsFixedArray = true)]
        public float[] GridValues { get; set; }
        
        [RealName("brokenGlass")]
        public uint BrokenGlass { get; set; }
        
        [RealName("brokenLights")]
        public uint BrokenLights { get; set; }
        
        [RealName("flatTire")]
        public byte FlatTire { get; set; }
        
        [RealName("windshieldShattered")]
        public bool WindshieldShattered { get; set; }
        
        [RealName("windshieldPoints")]
        public Vector3[] WindshieldPoints { get; set; }
        
        [RealName("detachedParts")]
        public CName[] DetachedParts { get; set; }
    }
}
