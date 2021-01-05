using CyberCAT.Core.Classes.Mapping.Global;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("gameinteractionsChoiceCaption")]
    public class GameinteractionsChoiceCaption : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("parts")]
        public Handle<GameinteractionsChoiceCaptionPart>[] Parts { get; set; }
    }
}
