using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameSVisualTagProcessing")]
    public class GameSVisualTagProcessing : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("areaType")]
        public DumpedEnums.gamedataEquipmentArea? AreaType { get; set; }
        
        [RealName("showItem")]
        public bool ShowItem { get; set; }
    }
}
