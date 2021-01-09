using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameinteractionsChoiceCaption")]
    public class GameinteractionsChoiceCaption : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("parts")]
        public Handle<GameinteractionsChoiceCaptionPart>[] Parts { get; set; }
    }
}
