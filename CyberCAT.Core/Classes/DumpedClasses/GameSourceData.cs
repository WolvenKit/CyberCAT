using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameSourceData")]
    public class GameSourceData : ISerializable
    {
        [RealName("name")]
        [RealType("CName")]
        public string Name { get; set; }
        
        [RealName("savable")]
        [RealType("Bool")]
        public bool Savable { get; set; }
    }
}
