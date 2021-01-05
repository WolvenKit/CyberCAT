using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("gameinteractionsChoiceLookAtDescriptor")]
    public class GameinteractionsChoiceLookAtDescriptor : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("type")]
        public DumpedEnums.gameinteractionsChoiceLookAtType? Type { get; set; }
        
        [RealName("slotName")]
        [RealType("CName")]
        public string SlotName { get; set; }
        
        [RealName("offset")]
        public Vector3 Offset { get; set; }
        
        [RealName("orbId")]
        public GameinteractionsOrbID OrbId { get; set; }
    }
}
