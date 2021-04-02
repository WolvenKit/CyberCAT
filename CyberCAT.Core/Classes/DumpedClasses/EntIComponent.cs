using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("entIComponent")]
    public class EntIComponent : IScriptable
    {
        [RealName("name")]
        public CName Name { get; set; }

        // TODO: Check type
        [RealName("id")]
        [RealType("CRUID")]
        public dynamic Id { get; set; }
        
        [RealName("isReplicable")]
        public bool IsReplicable { get; set; }
    }
}
