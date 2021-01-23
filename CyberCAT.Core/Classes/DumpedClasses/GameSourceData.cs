using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameSourceData")]
    public class GameSourceData : ISerializable
    {
        [RealName("name")]
        public CName Name { get; set; }
        
        [RealName("savable")]
        public bool Savable { get; set; }
    }
}
