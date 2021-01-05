using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("gameSVisualTagProcessing")]
    public class GameSVisualTagProcessing : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("areaType")]
        public DumpedEnums.gamedataEquipmentArea? AreaType { get; set; }
        
        [RealName("showItem")]
        [RealType("Bool")]
        public bool ShowItem { get; set; }
    }
}
