using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("gameSSlotActiveItems")]
    public class GameSSlotActiveItems : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("rightHandItem")]
        public GameItemID RightHandItem { get; set; }
        
        [RealName("leftHandItem")]
        public GameItemID LeftHandItem { get; set; }
    }
}
