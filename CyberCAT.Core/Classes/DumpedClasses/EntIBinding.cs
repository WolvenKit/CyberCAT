using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("entIBinding")]
    public class EntIBinding : ISerializable
    {
        [RealName("enabled")]
        public bool Enabled { get; set; }
        
        [RealName("enableMask")]
        public EntTagMask EnableMask { get; set; }
        
        [RealName("bindName")]
        public CName BindName { get; set; }
    }
}
