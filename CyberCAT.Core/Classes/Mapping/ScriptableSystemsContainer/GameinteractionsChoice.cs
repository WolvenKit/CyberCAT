using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("gameinteractionsChoice")]
    public class GameinteractionsChoice : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("caption")]
        [RealType("String")]
        public string Caption { get; set; }
        
        [RealName("captionParts")]
        public GameinteractionsChoiceCaption CaptionParts { get; set; }
        
        [RealName("data")]
        [RealType("Variant")]
        public dynamic[] Data { get; set; }
        
        [RealName("choiceMetaData")]
        public GameinteractionsChoiceMetaData ChoiceMetaData { get; set; }
        
        [RealName("lookAtDescriptor")]
        public GameinteractionsChoiceLookAtDescriptor LookAtDescriptor { get; set; }
    }
}
