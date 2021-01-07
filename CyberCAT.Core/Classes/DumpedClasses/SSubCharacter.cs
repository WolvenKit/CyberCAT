using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SSubCharacter")]
    public class SSubCharacter : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("persistentID")]
        public GamePersistentID PersistentID { get; set; }
        
        [RealName("subCharType")]
        public DumpedEnums.gamedataSubCharacter? SubCharType { get; set; }
        
        [RealName("equipmentData")]
        public Handle<EquipmentSystemPlayerData> EquipmentData { get; set; }
    }
}
