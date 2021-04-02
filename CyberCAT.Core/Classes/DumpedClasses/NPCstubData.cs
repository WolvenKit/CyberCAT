using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("NPCstubData")]
    public class NPCstubData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("spawnerID")]
        public EntEntityID SpawnerID { get; set; }
        
        [RealName("entryID")]
        public CName EntryID { get; set; }
    }
}
